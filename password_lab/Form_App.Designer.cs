
namespace password_lab
{
    partial class Form_App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_changePass = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.textBox_about = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Admin = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button_CreateUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_IsBlocked = new System.Windows.Forms.CheckBox();
            this.checkBox_IsRestPass = new System.Windows.Forms.CheckBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_events = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage_Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage_Admin);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 326);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.button_Exit);
            this.tabPage1.Controls.Add(this.button_changePass);
            this.tabPage1.Controls.Add(this.button_Logout);
            this.tabPage1.Controls.Add(this.textBox_about);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 294);
            this.tabPage1.TabIndex = 0;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.MenuText;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Exit.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_Exit.Location = new System.Drawing.Point(676, 198);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(80, 39);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Закрыть приложение";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_changePass
            // 
            this.button_changePass.BackColor = System.Drawing.SystemColors.MenuText;
            this.button_changePass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_changePass.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_changePass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_changePass.Location = new System.Drawing.Point(676, 65);
            this.button_changePass.Name = "button_changePass";
            this.button_changePass.Size = new System.Drawing.Size(80, 43);
            this.button_changePass.TabIndex = 3;
            this.button_changePass.Text = "Сменить пароль";
            this.button_changePass.UseVisualStyleBackColor = false;
            this.button_changePass.Click += new System.EventHandler(this.button_changePass_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.SystemColors.MenuText;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Logout.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_Logout.Location = new System.Drawing.Point(676, 131);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(80, 40);
            this.button_Logout.TabIndex = 2;
            this.button_Logout.Text = "Выйти из аккаунта";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // textBox_about
            // 
            this.textBox_about.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_about.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_about.Location = new System.Drawing.Point(49, 65);
            this.textBox_about.Multiline = true;
            this.textBox_about.Name = "textBox_about";
            this.textBox_about.ReadOnly = true;
            this.textBox_about.Size = new System.Drawing.Size(594, 198);
            this.textBox_about.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сведения о проекте";
            // 
            // tabPage_Admin
            // 
            this.tabPage_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage_Admin.Controls.Add(this.button1);
            this.tabPage_Admin.Controls.Add(this.button_CreateUser);
            this.tabPage_Admin.Controls.Add(this.label4);
            this.tabPage_Admin.Controls.Add(this.label3);
            this.tabPage_Admin.Controls.Add(this.checkBox_IsBlocked);
            this.tabPage_Admin.Controls.Add(this.checkBox_IsRestPass);
            this.tabPage_Admin.Controls.Add(this.textBox_Pass);
            this.tabPage_Admin.Controls.Add(this.textBox_Login);
            this.tabPage_Admin.Controls.Add(this.label2);
            this.tabPage_Admin.Controls.Add(this.dataGridView1);
            this.tabPage_Admin.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Admin.Name = "tabPage_Admin";
            this.tabPage_Admin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Admin.Size = new System.Drawing.Size(788, 294);
            this.tabPage_Admin.TabIndex = 1;
            this.tabPage_Admin.Text = "Панель админа";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(417, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Применить изменения";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_CreateUser
            // 
            this.button_CreateUser.BackColor = System.Drawing.SystemColors.MenuText;
            this.button_CreateUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_CreateUser.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CreateUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_CreateUser.Location = new System.Drawing.Point(544, 231);
            this.button_CreateUser.Name = "button_CreateUser";
            this.button_CreateUser.Size = new System.Drawing.Size(75, 23);
            this.button_CreateUser.TabIndex = 8;
            this.button_CreateUser.Text = "Создать";
            this.button_CreateUser.UseVisualStyleBackColor = false;
            this.button_CreateUser.Click += new System.EventHandler(this.button_CreateUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("MV Boli", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(530, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль(можно оставить пустым)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("MV Boli", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(530, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Логин";
            // 
            // checkBox_IsBlocked
            // 
            this.checkBox_IsBlocked.AutoSize = true;
            this.checkBox_IsBlocked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox_IsBlocked.Font = new System.Drawing.Font("MV Boli", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_IsBlocked.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_IsBlocked.Location = new System.Drawing.Point(533, 204);
            this.checkBox_IsBlocked.Name = "checkBox_IsBlocked";
            this.checkBox_IsBlocked.Size = new System.Drawing.Size(123, 21);
            this.checkBox_IsBlocked.TabIndex = 5;
            this.checkBox_IsBlocked.Text = "Заблокирован";
            this.checkBox_IsBlocked.UseVisualStyleBackColor = false;
            // 
            // checkBox_IsRestPass
            // 
            this.checkBox_IsRestPass.AutoSize = true;
            this.checkBox_IsRestPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox_IsRestPass.Font = new System.Drawing.Font("MV Boli", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_IsRestPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_IsRestPass.Location = new System.Drawing.Point(533, 181);
            this.checkBox_IsRestPass.Name = "checkBox_IsRestPass";
            this.checkBox_IsRestPass.Size = new System.Drawing.Size(192, 21);
            this.checkBox_IsRestPass.TabIndex = 4;
            this.checkBox_IsRestPass.Text = "Ограничение на пароль";
            this.checkBox_IsRestPass.UseVisualStyleBackColor = false;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Pass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pass.Location = new System.Drawing.Point(544, 145);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(100, 21);
            this.textBox_Pass.TabIndex = 3;
            // 
            // textBox_Login
            // 
            this.textBox_Login.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Login.Location = new System.Drawing.Point(544, 97);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(100, 21);
            this.textBox_Login.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(514, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавить нового пользователя";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // textBox_events
            // 
            this.textBox_events.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_events.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_events.Location = new System.Drawing.Point(5, 336);
            this.textBox_events.Multiline = true;
            this.textBox_events.Name = "textBox_events";
            this.textBox_events.ReadOnly = true;
            this.textBox_events.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_events.Size = new System.Drawing.Size(788, 111);
            this.textBox_events.TabIndex = 1;
            // 
            // Form_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_events);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage_Admin.ResumeLayout(false);
            this.tabPage_Admin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage_Admin;
        private System.Windows.Forms.TextBox textBox_events;
        private System.Windows.Forms.TextBox textBox_about;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_changePass;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_CreateUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_IsBlocked;
        private System.Windows.Forms.CheckBox checkBox_IsRestPass;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}