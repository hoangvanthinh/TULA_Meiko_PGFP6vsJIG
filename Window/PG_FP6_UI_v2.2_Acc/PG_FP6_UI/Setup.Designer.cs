namespace PG_FP6_UI
{
    partial class Setup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.M_Stopbit = new System.Windows.Forms.ComboBox();
            this.M_Parity = new System.Windows.Forms.ComboBox();
            this.M_Databit = new System.Windows.Forms.ComboBox();
            this.M_Baud = new System.Windows.Forms.ComboBox();
            this.M_com = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.P_Stopbit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.P_Parity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.P_Databit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.P_Baud = new System.Windows.Forms.ComboBox();
            this.P_com = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.M_Stopbit);
            this.groupBox1.Controls.Add(this.M_Parity);
            this.groupBox1.Controls.Add(this.M_Databit);
            this.groupBox1.Controls.Add(this.M_Baud);
            this.groupBox1.Controls.Add(this.M_com);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TULA-MCU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stopbit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Databit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM";
            // 
            // M_Stopbit
            // 
            this.M_Stopbit.FormattingEnabled = true;
            this.M_Stopbit.Items.AddRange(new object[] {
            "1",
            "2"});
            this.M_Stopbit.Location = new System.Drawing.Point(163, 219);
            this.M_Stopbit.Name = "M_Stopbit";
            this.M_Stopbit.Size = new System.Drawing.Size(121, 21);
            this.M_Stopbit.TabIndex = 4;
            // 
            // M_Parity
            // 
            this.M_Parity.FormattingEnabled = true;
            this.M_Parity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.M_Parity.Location = new System.Drawing.Point(163, 169);
            this.M_Parity.Name = "M_Parity";
            this.M_Parity.Size = new System.Drawing.Size(121, 21);
            this.M_Parity.TabIndex = 3;
            // 
            // M_Databit
            // 
            this.M_Databit.FormattingEnabled = true;
            this.M_Databit.Items.AddRange(new object[] {
            "8"});
            this.M_Databit.Location = new System.Drawing.Point(163, 119);
            this.M_Databit.Name = "M_Databit";
            this.M_Databit.Size = new System.Drawing.Size(121, 21);
            this.M_Databit.TabIndex = 2;
            // 
            // M_Baud
            // 
            this.M_Baud.FormattingEnabled = true;
            this.M_Baud.Items.AddRange(new object[] {
            "19200",
            "9600"});
            this.M_Baud.Location = new System.Drawing.Point(163, 69);
            this.M_Baud.Name = "M_Baud";
            this.M_Baud.Size = new System.Drawing.Size(121, 21);
            this.M_Baud.TabIndex = 1;
            // 
            // M_com
            // 
            this.M_com.FormattingEnabled = true;
            this.M_com.Location = new System.Drawing.Point(163, 19);
            this.M_com.Name = "M_com";
            this.M_com.Size = new System.Drawing.Size(121, 21);
            this.M_com.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.P_Stopbit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.P_Parity);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.P_Databit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.P_Baud);
            this.groupBox2.Controls.Add(this.P_com);
            this.groupBox2.Location = new System.Drawing.Point(394, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PGFP6-RENESAS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stopbit";
            // 
            // P_Stopbit
            // 
            this.P_Stopbit.FormattingEnabled = true;
            this.P_Stopbit.Items.AddRange(new object[] {
            "1",
            "2"});
            this.P_Stopbit.Location = new System.Drawing.Point(189, 219);
            this.P_Stopbit.Name = "P_Stopbit";
            this.P_Stopbit.Size = new System.Drawing.Size(121, 21);
            this.P_Stopbit.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Parity";
            // 
            // P_Parity
            // 
            this.P_Parity.FormattingEnabled = true;
            this.P_Parity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.P_Parity.Location = new System.Drawing.Point(189, 169);
            this.P_Parity.Name = "P_Parity";
            this.P_Parity.Size = new System.Drawing.Size(121, 21);
            this.P_Parity.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Databit";
            // 
            // P_Databit
            // 
            this.P_Databit.FormattingEnabled = true;
            this.P_Databit.Items.AddRange(new object[] {
            "8"});
            this.P_Databit.Location = new System.Drawing.Point(189, 119);
            this.P_Databit.Name = "P_Databit";
            this.P_Databit.Size = new System.Drawing.Size(121, 21);
            this.P_Databit.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Baudrate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "COM";
            // 
            // P_Baud
            // 
            this.P_Baud.FormattingEnabled = true;
            this.P_Baud.Items.AddRange(new object[] {
            "19200",
            "9600"});
            this.P_Baud.Location = new System.Drawing.Point(189, 69);
            this.P_Baud.Name = "P_Baud";
            this.P_Baud.Size = new System.Drawing.Size(121, 21);
            this.P_Baud.TabIndex = 6;
            // 
            // P_com
            // 
            this.P_com.FormattingEnabled = true;
            this.P_com.Location = new System.Drawing.Point(189, 19);
            this.P_com.Name = "P_com";
            this.P_com.Size = new System.Drawing.Size(121, 21);
            this.P_com.TabIndex = 5;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(520, 310);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(82, 28);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(629, 310);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(85, 28);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 350);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setup";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox M_com;
        public System.Windows.Forms.ComboBox P_com;
        public System.Windows.Forms.ComboBox M_Stopbit;
        public System.Windows.Forms.ComboBox M_Parity;
        public System.Windows.Forms.ComboBox M_Databit;
        public System.Windows.Forms.ComboBox M_Baud;
        public System.Windows.Forms.ComboBox P_Stopbit;
        public System.Windows.Forms.ComboBox P_Parity;
        public System.Windows.Forms.ComboBox P_Databit;
        public System.Windows.Forms.ComboBox P_Baud;
    }
}