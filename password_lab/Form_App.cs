using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_lab
{
    public partial class Form_App : Form
    {
        private Form_Change_Pass form_change;
        private Events_List events;
        private Account this_acc;
        private List<Account> accounts;
        public Form_App(Account acc, List<Account> accounts, Events_List events)
        {
            InitializeComponent();
            this.accounts = accounts;
            init(acc, events);
            init_DataGrid();
            settingPrivate_DataGrid();


        }
        public Form_App(Account acc, Events_List events)
        {
            InitializeComponent();
            init(acc, events);
            tabControl1.TabPages.Remove(tabControl1.TabPages[1]);
        }
        public void init(Account acc, Events_List events)
        {
            this.events = events;
            this.DialogResult = DialogResult.OK;
            this_acc = acc;
            textBox_events.Text = events.getAllEvents();
            textBox_about.Text = "Программа парольной аутентификации пользователей" +
                                    Environment.NewLine + Environment.NewLine +
                                    "Программист: Дмитрий Железнев" + Environment.NewLine + 
                                    "группа: М-45" +
                                    Environment.NewLine + Environment.NewLine +
                                    "Вариант 5" + Environment.NewLine +
                                    "Ограничение на пароль: " +
                                    "Наличие цифр, знаков препинания и знаков арифметических операций";
        }
        private void init_DataGrid()
        {
            var coulumnLogin = new DataGridViewTextBoxColumn
            {
                HeaderText = "Пользователь"
            };
            var columnPass = new DataGridViewTextBoxColumn
            {
                HeaderText = "Пароль",
            };
            var coulumnIsBlocked = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Заблокирован"
            };
            var columnIsResPass = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Ограничение на пароль"
            };
            DataGridViewColumn[] columns = { coulumnLogin, columnPass,
                                            coulumnIsBlocked, columnIsResPass };
            dataGridView1.Columns.AddRange(columns);

            foreach (Account el in accounts)
            {
                dataGridView1.Rows.Add(el.login, el.password, el.isBlocked, el.isRestPass);
            }
        }
        public void settingPrivate_DataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            addEvent(events.logout(this_acc.login));
            this.Close();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void button_changePass_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            form_change = new Form_Change_Pass(this_acc, events);
            form_change.FormClosed += Form_ChangePass_FormClosed;
            form_change.Show();

        }
        private void Form_ChangePass_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            textBox_events.Text = events.getAllEvents();
            if (this_acc.login == "admin")
                dataGridView1[1, 0].Value = this_acc.password;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    accounts[e.RowIndex].login = (string)dataGridView1[0, e.RowIndex].Value;
                    break;
                case 1:
                    string password = (string)dataGridView1[1, e.RowIndex].Value;
                    if (password == "" || password == null) password = "_";
                    accounts[e.RowIndex].password = password;
                    break;
                case 2:
                    accounts[e.RowIndex].isBlocked = (bool)dataGridView1[2, e.RowIndex].Value;
                    if (accounts[e.RowIndex].isBlocked)
                    {
                        addEvent(events.blockingLogin(accounts[e.RowIndex].login, 
                                                                        Events_List.Status.OK));
                    }
                    break;
                case 3:
                    accounts[e.RowIndex].isRestPass = (bool)dataGridView1[3, e.RowIndex].Value;
                    break;
            }
            addEvent(events.adminChangeData((string)dataGridView1[0, e.RowIndex].Value));

        }

        private void button_CreateUser_Click(object sender, EventArgs e)
        {
            string login = textBox_Login.Text;
            if(login == "" || login == null)
            {
                MessageBox.Show("Логин не может быть пустым", "ошибка");
                addEvent(events.createUser("noname", Events_List.Status.NO));
                return;
            }
            if(accounts.FindIndex((acc) => acc.login == login) != -1)
            {
                MessageBox.Show("Аккаунт с данным логином уже существует", "ошибка");
                addEvent(events.createUser("login", Events_List.Status.NO));
                return;
            }
            bool isBlocked = checkBox_IsBlocked.Checked;
            bool isRestPass = checkBox_IsRestPass.Checked;
            if(textBox_Pass.Text == "" || textBox_Pass == null)
            {
                accounts.Add(new Account(login, "_", isBlocked, isRestPass));
            }
            else
            {
                accounts.Add(new Account(login, textBox_Pass.Text, isBlocked, isRestPass));
            }
            Account new_acc = accounts[accounts.Count - 1];
            dataGridView1.Rows.Add(new_acc.login, new_acc.password, 
                                                    new_acc.isBlocked, new_acc.isRestPass);
            addEvent(events.createUser(new_acc.login, Events_List.Status.OK));

            textBox_Login.Text = "";
            textBox_Pass.Text = "";
            checkBox_IsBlocked.Checked = false;
            checkBox_IsRestPass.Checked = false;
        }
        private void addEvent(string evnt)
        {
            textBox_events.Text = evnt + Environment.NewLine + textBox_events.Text;
        }
    }
}
