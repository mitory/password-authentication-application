
namespace password_lab
{
    partial class Form_Change_Pass
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_OldPass = new System.Windows.Forms.TextBox();
            this.button_ChangePass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NewPass = new System.Windows.Forms.TextBox();
            this.textBox_CopyNewPass = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Старый пароль";
            // 
            // textBox_OldPass
            // 
            this.textBox_OldPass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_OldPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OldPass.Location = new System.Drawing.Point(55, 48);
            this.textBox_OldPass.Name = "textBox_OldPass";
            this.textBox_OldPass.PasswordChar = '*';
            this.textBox_OldPass.Size = new System.Drawing.Size(114, 21);
            this.textBox_OldPass.TabIndex = 1;
            this.textBox_OldPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_OldPass_KeyDown);
            // 
            // button_ChangePass
            // 
            this.button_ChangePass.BackColor = System.Drawing.SystemColors.MenuText;
            this.button_ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_ChangePass.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangePass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_ChangePass.Location = new System.Drawing.Point(56, 205);
            this.button_ChangePass.Name = "button_ChangePass";
            this.button_ChangePass.Size = new System.Drawing.Size(107, 40);
            this.button_ChangePass.TabIndex = 2;
            this.button_ChangePass.Text = "Изменить пароль";
            this.button_ChangePass.UseVisualStyleBackColor = false;
            this.button_ChangePass.Click += new System.EventHandler(this.button_ChangePass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(53, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Новый пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(39, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Повторите пароль";
            // 
            // textBox_NewPass
            // 
            this.textBox_NewPass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_NewPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewPass.Location = new System.Drawing.Point(52, 107);
            this.textBox_NewPass.Name = "textBox_NewPass";
            this.textBox_NewPass.PasswordChar = '*';
            this.textBox_NewPass.Size = new System.Drawing.Size(114, 21);
            this.textBox_NewPass.TabIndex = 5;
            this.textBox_NewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_NewPass_KeyDown);
            // 
            // textBox_CopyNewPass
            // 
            this.textBox_CopyNewPass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_CopyNewPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CopyNewPass.Location = new System.Drawing.Point(52, 169);
            this.textBox_CopyNewPass.Name = "textBox_CopyNewPass";
            this.textBox_CopyNewPass.PasswordChar = '*';
            this.textBox_CopyNewPass.Size = new System.Drawing.Size(114, 21);
            this.textBox_CopyNewPass.TabIndex = 6;
            this.textBox_CopyNewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_CopyNewPass_KeyDown);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.SystemColors.WindowText;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Cancel.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_Cancel.Location = new System.Drawing.Point(74, 251);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 281);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(207, 59);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Пароль должен содержать цифры, знаки препинания и знаки арифметических операций ";
            // 
            // Form_Change_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(239, 352);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_CopyNewPass);
            this.Controls.Add(this.textBox_NewPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_ChangePass);
            this.Controls.Add(this.textBox_OldPass);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Change_Pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_OldPass;
        private System.Windows.Forms.Button button_ChangePass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_NewPass;
        private System.Windows.Forms.TextBox textBox_CopyNewPass;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox1;
    }
}