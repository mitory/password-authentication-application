using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_lab
{
    public partial class Form_Pass : Form
    {
        private Form_App form_app;
        private Events_List events;
        private List<Account> accounts;
        private Account this_acc;
        private int counts = 0;
        public Form_Pass(Account acc, List<Account> accounts, Events_List events)
        {
            InitializeComponent();
            init(acc, events);
            this.accounts = accounts;
        }
        public Form_Pass(Account acc, Events_List events)
        {
            InitializeComponent();
            init(acc, events);
        }
        public void init(Account acc, Events_List events)
        {
            if (isEmptyPassword(acc.password))
                showCopyPassword();
            this_acc = acc;
            this.events = events;
            this.DialogResult = DialogResult.OK;
        }
        private bool isEmptyPassword(string password)
        {
            return password == "_";
        }
        private void showCopyPassword()
        {
            textBox_CopyPass.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
        }

        private bool isCorrectPass(string password)
        {
            Regex rx = new Regex("(?=.*[0-9])(?=.*[.,:;!?-])(?=.*[*+/-])");
            return rx.IsMatch(password);
        }

        private void button_Pass_Click(object sender, EventArgs e)
        {
            if(!this_acc.isRestPass || isCorrectPass(textBox_Pass.Text))
            {
                if (isEmptyPassword(this_acc.password))
                {
                    if (!(textBox_Pass.Text == textBox_CopyPass.Text))
                    {
                        showError("Пароли не совпадают");
                        addCounts();
                        return;
                    }
                    else
                    {
                        if(textBox_Pass.Text == "")
                        {
                            showError("Пароль не может быть пустым");
                            return;
                        }
                        this_acc.password = textBox_Pass.Text;
                    }
                }
                if (this_acc.password == textBox_Pass.Text)
                {
                    if (!this_acc.isBlocked)
                    {
                        events.inputPassword(textBox_Pass.Text, Events_List.Status.OK);
                        this.Visible = false;
                        this.Enabled = false;
                        if (this_acc.login == "admin")
                        {
                            form_app = new Form_App(this_acc, accounts, events);
                        }
                        else
                        {
                            form_app = new Form_App(this_acc, events);
                        }
                        form_app.FormClosed += Form_App_FormClosed;
                        form_app.Show();
                    }
                    else
                    {
                        showError("Пользователь заблокирован");
                    }
                }
                else
                {
                    showError("Введен не верный пароль");
                    addCounts();
                }
                
            }
            else
            {
                showError("Пароль не соответсвует требованию");
                addCounts();
            }
        }
        private void Form_App_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(form_app.DialogResult == DialogResult.No)
            {
                this.DialogResult = DialogResult.No;
            }
            this.Close();
        }
        private void showError(string message)
        {
            MessageBox.Show(message, "ошибка");
            events.inputPassword(textBox_Pass.Text, Events_List.Status.NO);
            textBox_Pass.Text = "";
            textBox_CopyPass.Text = "";
        }
        private void addCounts()
        {
            ++counts;
            if (counts == 3)
            {
                if (this_acc.login == "admin")
                {
                    this.DialogResult = DialogResult.No;
                }
                else
                {
                    this_acc.isBlocked = true;
                    events.blockingLogin(this_acc.login, Events_List.Status.OK);
                }
                this.Close();
            }
        }
        private void Form_Pass_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            keyEvent(sender, e);
            if(e.KeyCode == Keys.Down && textBox_CopyPass.Enabled)
            {
                textBox_CopyPass.Focus();
            }
        }

        private void textBox_CopyPass_KeyDown(object sender, KeyEventArgs e)
        {
            keyEvent(sender, e);
            if(e.KeyCode == Keys.Up)
            {
                textBox_Pass.Focus();
            }
        }
        private void keyEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button_Pass_Click(sender, e);
            }
            if(e.KeyCode == Keys.Escape)
            {
                button1_Click(sender, e);
            }
        }
    }
}
