namespace PG_FP6_UI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.QR_code = new System.Windows.Forms.TextBox();
            this.Command = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.File_Checksum = new System.Windows.Forms.Label();
            this.Filename = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.CLR = new System.Windows.Forms.Button();
            this.Status_PGFP6 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LED_MCU = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.t1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Command_send = new System.Windows.Forms.TextBox();
            this.Clear_command = new System.Windows.Forms.Button();
            this.C_Files = new System.Windows.Forms.Button();
            this.C_sum = new System.Windows.Forms.Button();
            this.C_Selftest = new System.Windows.Forms.Button();
            this.C_Esr = new System.Windows.Forms.Button();
            this.C_ep = new System.Windows.Forms.Button();
            this.Box_Pass = new System.Windows.Forms.TextBox();
            this.Box_NG = new System.Windows.Forms.TextBox();
            this.Box_Sum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Version_File = new System.Windows.Forms.Label();
            this.checksumMCU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fcks = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.S_system = new System.Windows.Forms.Button();
            this.CodeModel_setup = new System.Windows.Forms.Label();
            this.jig_open = new System.Windows.Forms.Button();
            this.jig_close = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Logout = new System.Windows.Forms.Button();
            this.ClearQR = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QR_code
            // 
            this.QR_code.BackColor = System.Drawing.Color.Black;
            this.QR_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QR_code.ForeColor = System.Drawing.Color.Yellow;
            this.QR_code.Location = new System.Drawing.Point(107, 199);
            this.QR_code.Name = "QR_code";
            this.QR_code.ReadOnly = true;
            this.QR_code.Size = new System.Drawing.Size(705, 49);
            this.QR_code.TabIndex = 0;
            this.QR_code.TextChanged += new System.EventHandler(this.QR_code_TextChanged);
            this.QR_code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QR_code_KeyUp);
            // 
            // Command
            // 
            this.Command.BackColor = System.Drawing.Color.Black;
            this.Command.ForeColor = System.Drawing.Color.Yellow;
            this.Command.Location = new System.Drawing.Point(964, 112);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(374, 450);
            this.Command.TabIndex = 2;
            this.Command.Text = "";
            this.Command.TextChanged += new System.EventHandler(this.Command_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(839, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Commands";
            // 
            // File_Checksum
            // 
            this.File_Checksum.AutoSize = true;
            this.File_Checksum.Font = new System.Drawing.Font("OCR-B 10 BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_Checksum.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.File_Checksum.Location = new System.Drawing.Point(234, 118);
            this.File_Checksum.Name = "File_Checksum";
            this.File_Checksum.Size = new System.Drawing.Size(72, 33);
            this.File_Checksum.TabIndex = 7;
            this.File_Checksum.Text = "---";
            // 
            // Filename
            // 
            this.Filename.AutoSize = true;
            this.Filename.Font = new System.Drawing.Font("OCR-B 10 BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filename.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Filename.Location = new System.Drawing.Point(234, 32);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(72, 33);
            this.Filename.TabIndex = 8;
            this.Filename.Text = "---";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LightGray;
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Start.Enabled = false;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(508, 324);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(377, 218);
            this.Start.TabIndex = 10;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Start_MouseDown);
            this.Start.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Start_MouseUp);
            // 
            // CLR
            // 
            this.CLR.BackColor = System.Drawing.Color.LightGray;
            this.CLR.Enabled = false;
            this.CLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLR.Location = new System.Drawing.Point(33, 483);
            this.CLR.Name = "CLR";
            this.CLR.Size = new System.Drawing.Size(385, 59);
            this.CLR.TabIndex = 11;
            this.CLR.Text = "CLEAR";
            this.CLR.UseVisualStyleBackColor = false;
            this.CLR.Click += new System.EventHandler(this.CLR_Click);
            // 
            // Status_PGFP6
            // 
            this.Status_PGFP6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Status_PGFP6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Status_PGFP6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_PGFP6.Location = new System.Drawing.Point(33, 324);
            this.Status_PGFP6.Name = "Status_PGFP6";
            this.Status_PGFP6.Size = new System.Drawing.Size(385, 135);
            this.Status_PGFP6.TabIndex = 13;
            this.Status_PGFP6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Status_PGFP6.BackColorChanged += new System.EventHandler(this.Status_PGFP6_BackColorChanged);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(964, 647);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 14;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LED_MCU
            // 
            this.LED_MCU.BackColor = System.Drawing.Color.DodgerBlue;
            this.LED_MCU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LED_MCU.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LED_MCU.Location = new System.Drawing.Point(1311, 37);
            this.LED_MCU.Name = "LED_MCU";
            this.LED_MCU.Size = new System.Drawing.Size(27, 53);
            this.LED_MCU.TabIndex = 15;
            this.LED_MCU.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.t1ToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Enabled = false;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "Data";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.setupToolStripMenuItem.Text = "Port";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // t1ToolStripMenuItem
            // 
            this.t1ToolStripMenuItem.Name = "t1ToolStripMenuItem";
            this.t1ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.t1ToolStripMenuItem.Text = "Login";
            this.t1ToolStripMenuItem.Click += new System.EventHandler(this.t1ToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Command_send
            // 
            this.Command_send.Location = new System.Drawing.Point(1058, 648);
            this.Command_send.Name = "Command_send";
            this.Command_send.Size = new System.Drawing.Size(279, 20);
            this.Command_send.TabIndex = 18;
            // 
            // Clear_command
            // 
            this.Clear_command.Location = new System.Drawing.Point(1262, 568);
            this.Clear_command.Name = "Clear_command";
            this.Clear_command.Size = new System.Drawing.Size(75, 25);
            this.Clear_command.TabIndex = 22;
            this.Clear_command.Text = "Delete";
            this.Clear_command.UseVisualStyleBackColor = true;
            this.Clear_command.Click += new System.EventHandler(this.Clear_command_Click);
            // 
            // C_Files
            // 
            this.C_Files.Location = new System.Drawing.Point(964, 568);
            this.C_Files.Name = "C_Files";
            this.C_Files.Size = new System.Drawing.Size(75, 25);
            this.C_Files.TabIndex = 23;
            this.C_Files.Text = "Files";
            this.C_Files.UseVisualStyleBackColor = true;
            this.C_Files.Visible = false;
            this.C_Files.Click += new System.EventHandler(this.C_Files_Click);
            // 
            // C_sum
            // 
            this.C_sum.Location = new System.Drawing.Point(1059, 568);
            this.C_sum.Name = "C_sum";
            this.C_sum.Size = new System.Drawing.Size(75, 25);
            this.C_sum.TabIndex = 24;
            this.C_sum.Text = "Sum";
            this.C_sum.UseVisualStyleBackColor = true;
            this.C_sum.Visible = false;
            this.C_sum.Click += new System.EventHandler(this.C_sum_Click);
            // 
            // C_Selftest
            // 
            this.C_Selftest.Enabled = false;
            this.C_Selftest.Location = new System.Drawing.Point(1162, 602);
            this.C_Selftest.Name = "C_Selftest";
            this.C_Selftest.Size = new System.Drawing.Size(75, 25);
            this.C_Selftest.TabIndex = 27;
            this.C_Selftest.Text = "Self test";
            this.C_Selftest.UseVisualStyleBackColor = true;
            this.C_Selftest.Visible = false;
            this.C_Selftest.Click += new System.EventHandler(this.C_Selftest_Click);
            // 
            // C_Esr
            // 
            this.C_Esr.Location = new System.Drawing.Point(1059, 602);
            this.C_Esr.Name = "C_Esr";
            this.C_Esr.Size = new System.Drawing.Size(75, 25);
            this.C_Esr.TabIndex = 26;
            this.C_Esr.Text = "Erase";
            this.C_Esr.UseVisualStyleBackColor = true;
            this.C_Esr.Visible = false;
            this.C_Esr.Click += new System.EventHandler(this.C_Esr_Click);
            // 
            // C_ep
            // 
            this.C_ep.Location = new System.Drawing.Point(964, 602);
            this.C_ep.Name = "C_ep";
            this.C_ep.Size = new System.Drawing.Size(75, 25);
            this.C_ep.TabIndex = 28;
            this.C_ep.Text = "Dowload";
            this.C_ep.UseVisualStyleBackColor = true;
            this.C_ep.Visible = false;
            this.C_ep.Click += new System.EventHandler(this.C_ep_Click);
            // 
            // Box_Pass
            // 
            this.Box_Pass.BackColor = System.Drawing.Color.Black;
            this.Box_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Pass.ForeColor = System.Drawing.Color.Lime;
            this.Box_Pass.Location = new System.Drawing.Point(240, 75);
            this.Box_Pass.Name = "Box_Pass";
            this.Box_Pass.Size = new System.Drawing.Size(70, 38);
            this.Box_Pass.TabIndex = 29;
            this.Box_Pass.Text = "0";
            // 
            // Box_NG
            // 
            this.Box_NG.BackColor = System.Drawing.Color.Black;
            this.Box_NG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_NG.ForeColor = System.Drawing.Color.Red;
            this.Box_NG.Location = new System.Drawing.Point(357, 73);
            this.Box_NG.Name = "Box_NG";
            this.Box_NG.Size = new System.Drawing.Size(70, 38);
            this.Box_NG.TabIndex = 30;
            this.Box_NG.Text = "0";
            // 
            // Box_Sum
            // 
            this.Box_Sum.BackColor = System.Drawing.Color.Black;
            this.Box_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Sum.ForeColor = System.Drawing.Color.Yellow;
            this.Box_Sum.Location = new System.Drawing.Point(475, 73);
            this.Box_Sum.Name = "Box_Sum";
            this.Box_Sum.Size = new System.Drawing.Size(70, 38);
            this.Box_Sum.TabIndex = 31;
            this.Box_Sum.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(492, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 33);
            this.label2.TabIndex = 32;
            this.label2.Text = "Σ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(351, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 33);
            this.label8.TabIndex = 33;
            this.label8.Text = "ERR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(234, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 33);
            this.label9.TabIndex = 34;
            this.label9.Text = "PASS";
            // 
            // Version_File
            // 
            this.Version_File.AutoSize = true;
            this.Version_File.Font = new System.Drawing.Font("OCR-B 10 BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version_File.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Version_File.Location = new System.Drawing.Point(234, 75);
            this.Version_File.Name = "Version_File";
            this.Version_File.Size = new System.Drawing.Size(72, 33);
            this.Version_File.TabIndex = 35;
            this.Version_File.Text = "---";
            // 
            // checksumMCU
            // 
            this.checksumMCU.BackColor = System.Drawing.Color.Black;
            this.checksumMCU.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checksumMCU.ForeColor = System.Drawing.Color.White;
            this.checksumMCU.Location = new System.Drawing.Point(15, 73);
            this.checksumMCU.Name = "checksumMCU";
            this.checksumMCU.Size = new System.Drawing.Size(142, 38);
            this.checksumMCU.TabIndex = 36;
            this.checksumMCU.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 39);
            this.label4.TabIndex = 37;
            this.label4.Text = "Total sum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR-B 10 BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(10, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 39;
            this.label1.Text = "Checksum :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR-B 10 BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(10, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 33);
            this.label5.TabIndex = 40;
            this.label5.Text = "File Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR-B 10 BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(10, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 33);
            this.label6.TabIndex = 41;
            this.label6.Text = "Ver      :";
            // 
            // fcks
            // 
            this.fcks.Location = new System.Drawing.Point(1162, 568);
            this.fcks.Name = "fcks";
            this.fcks.Size = new System.Drawing.Size(75, 25);
            this.fcks.TabIndex = 42;
            this.fcks.Text = "fcks";
            this.fcks.UseVisualStyleBackColor = true;
            this.fcks.Visible = false;
            this.fcks.Click += new System.EventHandler(this.fcks_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checksumMCU);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Box_Pass);
            this.groupBox1.Controls.Add(this.Box_NG);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Box_Sum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(33, 557);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 125);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PG-FP6-Report";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Version_File);
            this.groupBox2.Controls.Add(this.File_Checksum);
            this.groupBox2.Controls.Add(this.Filename);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(33, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 156);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program file";
            // 
            // S_system
            // 
            this.S_system.BackColor = System.Drawing.Color.Black;
            this.S_system.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_system.ForeColor = System.Drawing.Color.Red;
            this.S_system.Location = new System.Drawing.Point(964, 37);
            this.S_system.Name = "S_system";
            this.S_system.Size = new System.Drawing.Size(89, 53);
            this.S_system.TabIndex = 46;
            this.S_system.Text = "Disconnect";
            this.S_system.UseVisualStyleBackColor = false;
            this.S_system.Click += new System.EventHandler(this.S_system_Click);
            // 
            // CodeModel_setup
            // 
            this.CodeModel_setup.AutoSize = true;
            this.CodeModel_setup.Font = new System.Drawing.Font("OCR-B 10 BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeModel_setup.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CodeModel_setup.Location = new System.Drawing.Point(100, 272);
            this.CodeModel_setup.Name = "CodeModel_setup";
            this.CodeModel_setup.Size = new System.Drawing.Size(83, 38);
            this.CodeModel_setup.TabIndex = 57;
            this.CodeModel_setup.Text = "---";
            // 
            // jig_open
            // 
            this.jig_open.BackColor = System.Drawing.Color.Gold;
            this.jig_open.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.jig_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jig_open.ForeColor = System.Drawing.Color.Black;
            this.jig_open.Location = new System.Drawing.Point(38, 31);
            this.jig_open.Name = "jig_open";
            this.jig_open.Size = new System.Drawing.Size(207, 36);
            this.jig_open.TabIndex = 38;
            this.jig_open.Text = "OPEN";
            this.jig_open.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.jig_open.UseVisualStyleBackColor = false;
            // 
            // jig_close
            // 
            this.jig_close.BackColor = System.Drawing.Color.Lime;
            this.jig_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jig_close.ForeColor = System.Drawing.Color.Black;
            this.jig_close.Location = new System.Drawing.Point(38, 73);
            this.jig_close.Name = "jig_close";
            this.jig_close.Size = new System.Drawing.Size(207, 36);
            this.jig_close.TabIndex = 39;
            this.jig_close.Text = "CLOSE";
            this.jig_close.UseVisualStyleBackColor = false;
            this.jig_close.VisibleChanged += new System.EventHandler(this.jig_close_VisibleChanged);
            this.jig_close.Click += new System.EventHandler(this.jig_close_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.jig_close);
            this.groupBox3.Controls.Add(this.jig_open);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(613, 557);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 125);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "JIG";
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(1262, 602);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 25);
            this.Logout.TabIndex = 59;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Visible = false;
            this.Logout.VisibleChanged += new System.EventHandler(this.Logout_VisibleChanged);
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ClearQR
            // 
            this.ClearQR.Image = global::PG_FP6_UI.Properties.Resources.rs;
            this.ClearQR.Location = new System.Drawing.Point(829, 199);
            this.ClearQR.Name = "ClearQR";
            this.ClearQR.Size = new System.Drawing.Size(56, 49);
            this.ClearQR.TabIndex = 56;
            this.ClearQR.UseVisualStyleBackColor = true;
            this.ClearQR.Click += new System.EventHandler(this.ClearQR_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PG_FP6_UI.Properties.Resources.model;
            this.pictureBox3.Location = new System.Drawing.Point(33, 261);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1064, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CodeModel_setup);
            this.Controls.Add(this.ClearQR);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.S_system);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.fcks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.C_ep);
            this.Controls.Add(this.C_Selftest);
            this.Controls.Add(this.C_Esr);
            this.Controls.Add(this.C_sum);
            this.Controls.Add(this.C_Files);
            this.Controls.Add(this.Clear_command);
            this.Controls.Add(this.Command_send);
            this.Controls.Add(this.LED_MCU);
            this.Controls.Add(this.send);
            this.Controls.Add(this.Status_PGFP6);
            this.Controls.Add(this.CLR);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.QR_code);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TULA-PGFP6-v2.05.16012020";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QR_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label File_Checksum;
        private System.Windows.Forms.Label Filename;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button CLR;
        private System.Windows.Forms.Label Status_PGFP6;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.TextBox Command_send;
        private System.Windows.Forms.Button Clear_command;
        private System.Windows.Forms.Button C_Files;
        private System.Windows.Forms.Button C_sum;
        private System.Windows.Forms.Button C_Selftest;
        private System.Windows.Forms.Button C_Esr;
        private System.Windows.Forms.Button C_ep;
        private System.Windows.Forms.TextBox Box_Pass;
        private System.Windows.Forms.TextBox Box_NG;
        private System.Windows.Forms.TextBox Box_Sum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Version_File;
        private System.Windows.Forms.TextBox checksumMCU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button fcks;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button S_system;
        public System.Windows.Forms.Button LED_MCU;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ClearQR;
        public System.Windows.Forms.Label CodeModel_setup;
        private System.Windows.Forms.ToolStripMenuItem t1ToolStripMenuItem;
        private System.Windows.Forms.Button jig_close;
        private System.Windows.Forms.Button jig_open;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RichTextBox Command;
        public System.Windows.Forms.Button Logout;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

