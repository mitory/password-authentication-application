using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace password_lab
{
    public partial class Form1 : Form
    {
        private readonly string path_login = AppDomain.CurrentDomain.BaseDirectory + "login.dat";
        private readonly string path_event = AppDomain.CurrentDomain.BaseDirectory + "events.txt";
        Events_List events;
        Form_Pass form_pass;

        List<Account> accounts = new List<Account>();
        public Form1()
        {
            InitializeComponent();
            File_Accounts();
            events = new Events_List(path_event);
            events.workApp(Events_List.App.START);
        }

        private void File_Accounts()
        {
            try
            {
                using (BinaryReader reader = new BinaryReader(File.OpenRead(path_login)))
                {
                    string login;
                    string password;
                    bool isBlocked;
                    bool isRestPass;
                    while (reader.PeekChar() > -1)
                    {
                        login = reader.ReadString();
                        password = reader.ReadString();
                        isBlocked = reader.ReadBoolean();
                        isRestPass = reader.ReadBoolean();
                        accounts.Add(new Account(login, password, isBlocked, isRestPass));
                    }
                    
                }
            }
            catch (FileNotFoundException)
            {
                accounts.Add(new Account("admin", "_", false, false));
                using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(path_login)))
                {
                    writer.Write(accounts[0].login);
                    writer.Write(accounts[0].password);
                    writer.Write(accounts[0].isBlocked);
                    writer.Write(accounts[0].isRestPass);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Create(path_login)))
            {
                foreach (Account el in accounts)
                {
                    writer.Write(el.login);
                    writer.Write(el.password);
                    writer.Write(el.isBlocked);
                    writer.Write(el.isRestPass);
                }
            }
            events.workApp(Events_List.App.END);
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            int index = accounts.FindIndex(el => el.login == login);
            if (index != -1)
            {
                if (accounts[index].isBlocked)
                {
                    MessageBox.Show("Данный пользователь заблокирован", "ошибка");
                    events.inputLogin(login, Events_List.Status.NO);
                    textBox_login.Text = "";
                    return;
                }
                events.inputLogin(login, Events_List.Status.OK);
                if (login == "admin")
                {
                    form_pass = new Form_Pass(accounts[index], accounts, events);
                }
                else
                {
                    form_pass = new Form_Pass(accounts[index], events);
                }
                this.Visible = false;
                this.Enabled = false;
                form_pass.Show();
                form_pass.Enabled = true;

                form_pass.FormClosed += Form_Pass_FormClosed;
            }
            else
            {
                MessageBox.Show("Такого логина не существует", "ошибка");
                events.inputLogin(login, Events_List.Status.NOT_EXISTS);
                textBox_login.Text = "";
            }
        }
        private void Form_Pass_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            this.Enabled = true;
            textBox_login.Text = "";
            
            if (form_pass.DialogResult == DialogResult.No)
            {
                 this.Close();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.button_login_Click(sender, e);
        }

        private void textBox_login_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.button_login_Click(sender, e);
        }
    }
}
