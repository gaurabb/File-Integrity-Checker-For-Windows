namespace hashvalidator
{
    partial class frmHome
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
            this.rdbtnCalcSimpleHash = new System.Windows.Forms.RadioButton();
            this.grpBoxHome = new System.Windows.Forms.GroupBox();
            this.rdbtnValidateFileHmac = new System.Windows.Forms.RadioButton();
            this.rdbValidateFileWSimpleHash = new System.Windows.Forms.RadioButton();
            this.rdbtnGenerateHMAC = new System.Windows.Forms.RadioButton();
            this.grpBoxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtnCalcSimpleHash
            // 
            this.rdbtnCalcSimpleHash.AutoSize = true;
            this.rdbtnCalcSimpleHash.Location = new System.Drawing.Point(17, 35);
            this.rdbtnCalcSimpleHash.Name = "rdbtnCalcSimpleHash";
            this.rdbtnCalcSimpleHash.Size = new System.Drawing.Size(131, 17);
            this.rdbtnCalcSimpleHash.TabIndex = 0;
            this.rdbtnCalcSimpleHash.TabStop = true;
            this.rdbtnCalcSimpleHash.Text = "Generate Simple Hash";
            this.rdbtnCalcSimpleHash.UseVisualStyleBackColor = true;
            this.rdbtnCalcSimpleHash.Click += new System.EventHandler(this.rdbtnCalcSimpleHash_Click);
            // 
            // grpBoxHome
            // 
            this.grpBoxHome.Controls.Add(this.rdbtnValidateFileHmac);
            this.grpBoxHome.Controls.Add(this.rdbValidateFileWSimpleHash);
            this.grpBoxHome.Controls.Add(this.rdbtnGenerateHMAC);
            this.grpBoxHome.Controls.Add(this.rdbtnCalcSimpleHash);
            this.grpBoxHome.Location = new System.Drawing.Point(12, 12);
            this.grpBoxHome.Name = "grpBoxHome";
            this.grpBoxHome.Size = new System.Drawing.Size(200, 238);
            this.grpBoxHome.TabIndex = 1;
            this.grpBoxHome.TabStop = false;
            this.grpBoxHome.Text = "Select An Action:";
            // 
            // rdbtnValidateFileHmac
            // 
            this.rdbtnValidateFileHmac.AutoSize = true;
            this.rdbtnValidateFileHmac.Location = new System.Drawing.Point(17, 148);
            this.rdbtnValidateFileHmac.Name = "rdbtnValidateFileHmac";
            this.rdbtnValidateFileHmac.Size = new System.Drawing.Size(129, 17);
            this.rdbtnValidateFileHmac.TabIndex = 3;
            this.rdbtnValidateFileHmac.TabStop = true;
            this.rdbtnValidateFileHmac.Text = "Validate File w/HMAC";
            this.rdbtnValidateFileHmac.UseVisualStyleBackColor = true;
            this.rdbtnValidateFileHmac.Click += new System.EventHandler(this.rdbtnValidateFileHmac_Click);
            // 
            // rdbValidateFileWSimpleHash
            // 
            this.rdbValidateFileWSimpleHash.AutoSize = true;
            this.rdbValidateFileWSimpleHash.Location = new System.Drawing.Point(17, 110);
            this.rdbValidateFileWSimpleHash.Name = "rdbValidateFileWSimpleHash";
            this.rdbValidateFileWSimpleHash.Size = new System.Drawing.Size(157, 17);
            this.rdbValidateFileWSimpleHash.TabIndex = 2;
            this.rdbValidateFileWSimpleHash.TabStop = true;
            this.rdbValidateFileWSimpleHash.Text = "Validate File w/Simple Hash";
            this.rdbValidateFileWSimpleHash.UseVisualStyleBackColor = true;
            this.rdbValidateFileWSimpleHash.Click += new System.EventHandler(this.rdbValidateFileWSimpleHash_Click);
            // 
            // rdbtnGenerateHMAC
            // 
            this.rdbtnGenerateHMAC.AutoSize = true;
            this.rdbtnGenerateHMAC.Location = new System.Drawing.Point(17, 74);
            this.rdbtnGenerateHMAC.Name = "rdbtnGenerateHMAC";
            this.rdbtnGenerateHMAC.Size = new System.Drawing.Size(103, 17);
            this.rdbtnGenerateHMAC.TabIndex = 1;
            this.rdbtnGenerateHMAC.TabStop = true;
            this.rdbtnGenerateHMAC.Text = "Generate HMAC";
            this.rdbtnGenerateHMAC.UseVisualStyleBackColor = true;
            this.rdbtnGenerateHMAC.Click += new System.EventHandler(this.rdbtnGenerateHMAC_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(218, 262);
            this.Controls.Add(this.grpBoxHome);
            this.Name = "frmHome";
            this.Text = "Simple Hash Operations - Windows";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.grpBoxHome.ResumeLayout(false);
            this.grpBoxHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnCalcSimpleHash;
        private System.Windows.Forms.GroupBox grpBoxHome;
        private System.Windows.Forms.RadioButton rdbtnValidateFileHmac;
        private System.Windows.Forms.RadioButton rdbValidateFileWSimpleHash;
        private System.Windows.Forms.RadioButton rdbtnGenerateHMAC;
    }
}