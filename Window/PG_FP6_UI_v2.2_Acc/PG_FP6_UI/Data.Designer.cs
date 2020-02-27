namespace PG_FP6_UI
{
    partial class Data
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_model = new System.Windows.Forms.Button();
            this.Save_model = new System.Windows.Forms.Button();
            this.dataFilemodel = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.Folder = new System.Windows.Forms.TextBox();
            this.Browsefile = new System.Windows.Forms.Button();
            this.Model_list = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Code_model = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataFilemodel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "EE-02-K0RA-00002665";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "[1]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(48, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "[2]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(100, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "[3]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(178, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "[4]";
            // 
            // Add_model
            // 
            this.Add_model.Location = new System.Drawing.Point(417, 88);
            this.Add_model.Name = "Add_model";
            this.Add_model.Size = new System.Drawing.Size(105, 35);
            this.Add_model.TabIndex = 14;
            this.Add_model.Text = "ADD";
            this.Add_model.UseVisualStyleBackColor = true;
            this.Add_model.Click += new System.EventHandler(this.Add_model_Click);
            // 
            // Save_model
            // 
            this.Save_model.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save_model.Location = new System.Drawing.Point(417, 242);
            this.Save_model.Name = "Save_model";
            this.Save_model.Size = new System.Drawing.Size(105, 35);
            this.Save_model.TabIndex = 17;
            this.Save_model.Text = "Save";
            this.Save_model.UseVisualStyleBackColor = true;
            this.Save_model.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataFilemodel
            // 
            this.dataFilemodel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFilemodel.Location = new System.Drawing.Point(18, 88);
            this.dataFilemodel.Name = "dataFilemodel";
            this.dataFilemodel.Size = new System.Drawing.Size(360, 131);
            this.dataFilemodel.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(417, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Logdata file";
            // 
            // Folder
            // 
            this.Folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Folder.Location = new System.Drawing.Point(17, 305);
            this.Folder.Name = "Folder";
            this.Folder.Size = new System.Drawing.Size(292, 22);
            this.Folder.TabIndex = 21;
            // 
            // Browsefile
            // 
            this.Browsefile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Browsefile.Location = new System.Drawing.Point(315, 305);
            this.Browsefile.Name = "Browsefile";
            this.Browsefile.Size = new System.Drawing.Size(63, 22);
            this.Browsefile.TabIndex = 22;
            this.Browsefile.Text = "Browse";
            this.Browsefile.UseVisualStyleBackColor = true;
            this.Browsefile.Click += new System.EventHandler(this.Browsefile_Click);
            // 
            // Model_list
            // 
            this.Model_list.FormattingEnabled = true;
            this.Model_list.Location = new System.Drawing.Point(134, 232);
            this.Model_list.Name = "Model_list";
            this.Model_list.Size = new System.Drawing.Size(244, 21);
            this.Model_list.TabIndex = 23;
            this.Model_list.SelectedIndexChanged += new System.EventHandler(this.Model_list_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Choose Model:";
            // 
            // Code_model
            // 
            this.Code_model.AutoSize = true;
            this.Code_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code_model.Location = new System.Drawing.Point(17, 261);
            this.Code_model.Name = "Code_model";
            this.Code_model.Size = new System.Drawing.Size(81, 16);
            this.Code_model.TabIndex = 25;
            this.Code_model.Text = "Firmware ref";
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(534, 340);
            this.Controls.Add(this.Code_model);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Model_list);
            this.Controls.Add(this.Browsefile);
            this.Controls.Add(this.Folder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataFilemodel);
            this.Controls.Add(this.Save_model);
            this.Controls.Add(this.Add_model);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFilemodel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add_model;
        private System.Windows.Forms.Button Save_model;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataFilemodel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Folder;
        private System.Windows.Forms.Button Browsefile;
        private System.Windows.Forms.ComboBox Model_list;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label Code_model;
    }
}