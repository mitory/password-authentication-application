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
    public partial class Form_Change_Pass : Form
    {
        private Account this_acc;
        private Events_List events;
        public Form_Change_Pass(Account acc, Events_List events)
        {
            InitializeComponent();
            this_acc = acc;
            this.events = events;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ChangePass_Click(object sender, EventArgs e)
        {
            if(this_acc.password != textBox_OldPass.Text)
            {
                showError("Текущий пароль пользователя не совпадает с введенным");
                return;
            }
            if(textBox_NewPass.Text != textBox_CopyNewPass.Text)
            {
                showError("Неправильно повторен новый пароль");
                return;
            }
            if (this_acc.isRestPass && !isCorrectPass(textBox_NewPass.Text))
            {
                showError("Пароль не удовлетворяет требованиям");
                return;
            }
            if (textBox_NewPass.Text == "")
            {
                showError("Пароль не может быть пустым");
                return;
            }
            this_acc.password = textBox_NewPass.Text;
            events.changePassword(this_acc.login, Events_List.Status.OK);
            this.Close();
        }
        private void showError(string message)
        {
            MessageBox.Show(message, "ошибка");
            events.changePassword(this_acc.login, Events_List.Status.NO);
            textBox_OldPass.Text = "";
            textBox_NewPass.Text = "";
            textBox_CopyNewPass.Text = "";
        }
        private bool isCorrectPass(string password)
        {
            Regex rx = new Regex("(?=.*[0-9])(?=.*[.,:;!?-])(?=.*[*+/-])");
            return rx.IsMatch(password);
        }

        private void textBox_OldPass_KeyDown(object sender, KeyEventArgs e)
        {
            keyEvent(sender, e);
            if(e.KeyCode == Keys.Down)
            {
                textBox_NewPass.Focus();
            }
        }

        private void textBox_NewPass_KeyDown(object sender, KeyEventArgs e)
        {
            keyEvent(sender, e);
            if(e.KeyCode == Keys.Up)
            {
                textBox_OldPass.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox_CopyNewPass.Focus();
            }
        }

        private void textBox_CopyNewPass_KeyDown(object sender, KeyEventArgs e)
        {
            keyEvent(sender, e);
            if (e.KeyCode == Keys.Up)
            {
                textBox_NewPass.Focus();
            }
        }
        private void keyEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_ChangePass_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                button_Cancel_Click(sender, e);
            }
        }
    }
}
