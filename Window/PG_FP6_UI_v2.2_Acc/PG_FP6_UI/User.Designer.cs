namespace PG_FP6_UI
{
    partial class User
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
            this.Password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.changepass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(87, 59);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(214, 26);
            this.Password.TabIndex = 0;
            this.Password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Password_KeyUp);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(323, 59);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(76, 26);
            this.login.TabIndex = 1;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            // 
            // changepass
            // 
            this.changepass.Location = new System.Drawing.Point(87, 111);
            this.changepass.Name = "changepass";
            this.changepass.Size = new System.Drawing.Size(214, 26);
            this.changepass.TabIndex = 3;
            this.changepass.Text = "Change password";
            this.changepass.UseVisualStyleBackColor = true;
            this.changepass.Click += new System.EventHandler(this.changepass_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 182);
            this.Controls.Add(this.changepass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Password);
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changepass;
    }
}