namespace hashvalidator
{
    partial class frmHmac
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
            this.lblSelectHmacFile = new System.Windows.Forms.Label();
            this.txtFileToHmac = new System.Windows.Forms.TextBox();
            this.openFileToHmac = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseFileToHmac = new System.Windows.Forms.Button();
            this.lblSelectedFileBaner = new System.Windows.Forms.Label();
            this.lblSelectedFileValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHmacKey = new System.Windows.Forms.TextBox();
            this.lblHmacAlgo = new System.Windows.Forms.Label();
            this.cmbHmacAlgo = new System.Windows.Forms.ComboBox();
            this.lblCalculatedHmac = new System.Windows.Forms.Label();
            this.txtHmacValue = new System.Windows.Forms.TextBox();
            this.btnCalcHmac = new System.Windows.Forms.Button();
            this.btnSaveHmacToFile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectTypeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateSimpleHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateKeyedHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbGenerateKey = new System.Windows.Forms.CheckBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectHmacFile
            // 
            this.lblSelectHmacFile.AutoSize = true;
            this.lblSelectHmacFile.ForeColor = System.Drawing.Color.Red;
            this.lblSelectHmacFile.Location = new System.Drawing.Point(12, 69);
            this.lblSelectHmacFile.Name = "lblSelectHmacFile";
            this.lblSelectHmacFile.Size = new System.Drawing.Size(274, 13);
            this.lblSelectHmacFile.TabIndex = 0;
            this.lblSelectHmacFile.Text = "Select a file to calculate the HMAC or paste the file path:";
            // 
            // txtFileToHmac
            // 
            this.txtFileToHmac.Location = new System.Drawing.Point(15, 96);
            this.txtFileToHmac.Name = "txtFileToHmac";
            this.txtFileToHmac.Size = new System.Drawing.Size(522, 20);
            this.txtFileToHmac.TabIndex = 1;
            this.txtFileToHmac.Leave += new System.EventHandler(this.txtFileToHmac_Leave);
            // 
            // openFileToHmac
            // 
            this.openFileToHmac.FileName = "openFileDialog1";
            // 
            // btnBrowseFileToHmac
            // 
            this.btnBrowseFileToHmac.Location = new System.Drawing.Point(544, 92);
            this.btnBrowseFileToHmac.Name = "btnBrowseFileToHmac";
            this.btnBrowseFileToHmac.Size = new System.Drawing.Size(34, 23);
            this.btnBrowseFileToHmac.TabIndex = 2;
            this.btnBrowseFileToHmac.Text = "...";
            this.btnBrowseFileToHmac.UseVisualStyleBackColor = true;
            this.btnBrowseFileToHmac.Click += new System.EventHandler(this.btnBrowseFileToHmac_Click);
            // 
            // lblSelectedFileBaner
            // 
            this.lblSelectedFileBaner.AutoSize = true;
            this.lblSelectedFileBaner.Location = new System.Drawing.Point(12, 134);
            this.lblSelectedFileBaner.Name = "lblSelectedFileBaner";
            this.lblSelectedFileBaner.Size = new System.Drawing.Size(68, 13);
            this.lblSelectedFileBaner.TabIndex = 3;
            this.lblSelectedFileBaner.Text = "Selected file:";
            // 
            // lblSelectedFileValue
            // 
            this.lblSelectedFileValue.AutoSize = true;
            this.lblSelectedFileValue.Location = new System.Drawing.Point(98, 134);
            this.lblSelectedFileValue.Name = "lblSelectedFileValue";
            this.lblSelectedFileValue.Size = new System.Drawing.Size(83, 13);
            this.lblSelectedFileValue.TabIndex = 4;
            this.lblSelectedFileValue.Text = "No file selected!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Paste the key or check [Generate] to create and save a new key:";
            // 
            // txtHmacKey
            // 
            this.txtHmacKey.Location = new System.Drawing.Point(15, 202);
            this.txtHmacKey.Multiline = true;
            this.txtHmacKey.Name = "txtHmacKey";
            this.txtHmacKey.Size = new System.Drawing.Size(522, 51);
            this.txtHmacKey.TabIndex = 6;
            // 
            // lblHmacAlgo
            // 
            this.lblHmacAlgo.AutoSize = true;
            this.lblHmacAlgo.ForeColor = System.Drawing.Color.Red;
            this.lblHmacAlgo.Location = new System.Drawing.Point(12, 35);
            this.lblHmacAlgo.Name = "lblHmacAlgo";
            this.lblHmacAlgo.Size = new System.Drawing.Size(125, 13);
            this.lblHmacAlgo.TabIndex = 8;
            this.lblHmacAlgo.Text = "Selecte HMAC algorithm:";
            // 
            // cmbHmacAlgo
            // 
            this.cmbHmacAlgo.FormattingEnabled = true;
            this.cmbHmacAlgo.Items.AddRange(new object[] {
            "HMACMD5",
            "HMACSHA1",
            "HMACSHA256",
            "HMACSHA384",
            "HMACSHA512",
            "HMACRIPEMD160"});
            this.cmbHmacAlgo.Location = new System.Drawing.Point(143, 32);
            this.cmbHmacAlgo.Name = "cmbHmacAlgo";
            this.cmbHmacAlgo.Size = new System.Drawing.Size(121, 21);
            this.cmbHmacAlgo.TabIndex = 9;
            this.cmbHmacAlgo.Text = "--Select--";
            // 
            // lblCalculatedHmac
            // 
            this.lblCalculatedHmac.AutoSize = true;
            this.lblCalculatedHmac.Location = new System.Drawing.Point(12, 262);
            this.lblCalculatedHmac.Name = "lblCalculatedHmac";
            this.lblCalculatedHmac.Size = new System.Drawing.Size(71, 13);
            this.lblCalculatedHmac.TabIndex = 10;
            this.lblCalculatedHmac.Text = "HMAC Value:";
            // 
            // txtHmacValue
            // 
            this.txtHmacValue.Location = new System.Drawing.Point(89, 259);
            this.txtHmacValue.Multiline = true;
            this.txtHmacValue.Name = "txtHmacValue";
            this.txtHmacValue.Size = new System.Drawing.Size(448, 64);
            this.txtHmacValue.TabIndex = 11;
            // 
            // btnCalcHmac
            // 
            this.btnCalcHmac.Location = new System.Drawing.Point(543, 262);
            this.btnCalcHmac.Name = "btnCalcHmac";
            this.btnCalcHmac.Size = new System.Drawing.Size(75, 23);
            this.btnCalcHmac.TabIndex = 12;
            this.btnCalcHmac.Text = "Calculate";
            this.btnCalcHmac.UseVisualStyleBackColor = true;
            this.btnCalcHmac.Click += new System.EventHandler(this.btnCalcHmac_Click);
            // 
            // btnSaveHmacToFile
            // 
            this.btnSaveHmacToFile.Location = new System.Drawing.Point(543, 300);
            this.btnSaveHmacToFile.Name = "btnSaveHmacToFile";
            this.btnSaveHmacToFile.Size = new System.Drawing.Size(107, 23);
            this.btnSaveHmacToFile.TabIndex = 13;
            this.btnSaveHmacToFile.Text = "Save to file...";
            this.btnSaveHmacToFile.UseVisualStyleBackColor = true;
            this.btnSaveHmacToFile.Click += new System.EventHandler(this.btnSaveHmacToFile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectTypeHereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectTypeHereToolStripMenuItem
            // 
            this.selectTypeHereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateSimpleHashToolStripMenuItem,
            this.calculateKeyedHashToolStripMenuItem,
            this.validateFileToolStripMenuItem});
            this.selectTypeHereToolStripMenuItem.Name = "selectTypeHereToolStripMenuItem";
            this.selectTypeHereToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.selectTypeHereToolStripMenuItem.Text = "Select";
            // 
            // calculateSimpleHashToolStripMenuItem
            // 
            this.calculateSimpleHashToolStripMenuItem.Name = "calculateSimpleHashToolStripMenuItem";
            this.calculateSimpleHashToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.calculateSimpleHashToolStripMenuItem.Text = "Calculate Simple Hash";
            // 
            // calculateKeyedHashToolStripMenuItem
            // 
            this.calculateKeyedHashToolStripMenuItem.Name = "calculateKeyedHashToolStripMenuItem";
            this.calculateKeyedHashToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.calculateKeyedHashToolStripMenuItem.Text = "Calculate Keyed Hash";
            // 
            // validateFileToolStripMenuItem
            // 
            this.validateFileToolStripMenuItem.Name = "validateFileToolStripMenuItem";
            this.validateFileToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.validateFileToolStripMenuItem.Text = "Validate File";
            // 
            // cbGenerateKey
            // 
            this.cbGenerateKey.AutoSize = true;
            this.cbGenerateKey.Location = new System.Drawing.Point(370, 179);
            this.cbGenerateKey.Name = "cbGenerateKey";
            this.cbGenerateKey.Size = new System.Drawing.Size(199, 17);
            this.cbGenerateKey.TabIndex = 15;
            this.cbGenerateKey.Text = "Generate a random key? - 128 Bytes";
            this.cbGenerateKey.UseVisualStyleBackColor = true;
            this.cbGenerateKey.CheckedChanged += new System.EventHandler(this.cbGenerateKey_CheckedChanged);
            // 
            // frmHmac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(676, 338);
            this.Controls.Add(this.cbGenerateKey);
            this.Controls.Add(this.btnSaveHmacToFile);
            this.Controls.Add(this.btnCalcHmac);
            this.Controls.Add(this.txtHmacValue);
            this.Controls.Add(this.lblCalculatedHmac);
            this.Controls.Add(this.cmbHmacAlgo);
            this.Controls.Add(this.lblHmacAlgo);
            this.Controls.Add(this.txtHmacKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelectedFileValue);
            this.Controls.Add(this.lblSelectedFileBaner);
            this.Controls.Add(this.btnBrowseFileToHmac);
            this.Controls.Add(this.txtFileToHmac);
            this.Controls.Add(this.lblSelectHmacFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHmac";
            this.Text = "HMAC Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectHmacFile;
        private System.Windows.Forms.TextBox txtFileToHmac;
        private System.Windows.Forms.OpenFileDialog openFileToHmac;
        private System.Windows.Forms.Button btnBrowseFileToHmac;
        private System.Windows.Forms.Label lblSelectedFileBaner;
        private System.Windows.Forms.Label lblSelectedFileValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHmacKey;
        private System.Windows.Forms.Label lblHmacAlgo;
        private System.Windows.Forms.ComboBox cmbHmacAlgo;
        private System.Windows.Forms.Label lblCalculatedHmac;
        private System.Windows.Forms.TextBox txtHmacValue;
        private System.Windows.Forms.Button btnCalcHmac;
        private System.Windows.Forms.Button btnSaveHmacToFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectTypeHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateSimpleHashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateKeyedHashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateFileToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbGenerateKey;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}