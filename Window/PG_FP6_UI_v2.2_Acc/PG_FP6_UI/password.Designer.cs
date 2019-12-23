namespace PG_FP6_UI
{
    partial class password
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
            this.t_oldpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_newpass = new System.Windows.Forms.TextBox();
            this.t_verifypass = new System.Windows.Forms.TextBox();
            this.changepassword = new System.Windows.Forms.Button();
            this.L_oldpass = new System.Windows.Forms.Label();
            this.L_newpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old password:";
            // 
            // t_oldpass
            // 
            this.t_oldpass.Location = new System.Drawing.Point(167, 44);
            this.t_oldpass.Name = "t_oldpass";
            this.t_oldpass.Size = new System.Drawing.Size(142, 20);
            this.t_oldpass.TabIndex = 1;
            this.t_oldpass.TextChanged += new System.EventHandler(this.t_oldpass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Verify password:";
            // 
            // t_newpass
            // 
            this.t_newpass.Location = new System.Drawing.Point(167, 94);
            this.t_newpass.Name = "t_newpass";
            this.t_newpass.Size = new System.Drawing.Size(142, 20);
            this.t_newpass.TabIndex = 4;
            // 
            // t_verifypass
            // 
            this.t_verifypass.Location = new System.Drawing.Point(167, 144);
            this.t_verifypass.Name = "t_verifypass";
            this.t_verifypass.Size = new System.Drawing.Size(142, 20);
            this.t_verifypass.TabIndex = 5;
            this.t_verifypass.TextChanged += new System.EventHandler(this.t_verifypass_TextChanged);
            // 
            // changepassword
            // 
            this.changepassword.Location = new System.Drawing.Point(167, 195);
            this.changepassword.Name = "changepassword";
            this.changepassword.Size = new System.Drawing.Size(136, 23);
            this.changepassword.TabIndex = 6;
            this.changepassword.Text = "Change password\r\n";
            this.changepassword.UseVisualStyleBackColor = true;
            this.changepassword.Click += new System.EventHandler(this.changepassword_Click);
            // 
            // L_oldpass
            // 
            this.L_oldpass.AutoSize = true;
            this.L_oldpass.ForeColor = System.Drawing.Color.Red;
            this.L_oldpass.Location = new System.Drawing.Point(326, 47);
            this.L_oldpass.Name = "L_oldpass";
            this.L_oldpass.Size = new System.Drawing.Size(49, 13);
            this.L_oldpass.TabIndex = 7;
            this.L_oldpass.Text = "Incorrect";
            this.L_oldpass.Visible = false;
            // 
            // L_newpass
            // 
            this.L_newpass.AutoSize = true;
            this.L_newpass.ForeColor = System.Drawing.Color.Lime;
            this.L_newpass.Location = new System.Drawing.Point(326, 151);
            this.L_newpass.Name = "L_newpass";
            this.L_newpass.Size = new System.Drawing.Size(85, 13);
            this.L_newpass.TabIndex = 8;
            this.L_newpass.Text = "Password match";
            this.L_newpass.Visible = false;
            // 
            // password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 238);
            this.Controls.Add(this.L_newpass);
            this.Controls.Add(this.L_oldpass);
            this.Controls.Add(this.changepassword);
            this.Controls.Add(this.t_verifypass);
            this.Controls.Add(this.t_newpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_oldpass);
            this.Controls.Add(this.label1);
            this.Name = "password";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_oldpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_newpass;
        private System.Windows.Forms.TextBox t_verifypass;
        private System.Windows.Forms.Button changepassword;
        private System.Windows.Forms.Label L_oldpass;
        private System.Windows.Forms.Label L_newpass;
    }
}