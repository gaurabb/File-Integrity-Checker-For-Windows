using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hashvalidator
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        

        private void rdbtnCalcSimpleHash_Click(object sender, EventArgs e)
        {
            var formCalcSimpleHash = new frmSimplehashcalculator();
            formCalcSimpleHash.Show();
        }

        private void rdbtnGenerateHMAC_Click(object sender, EventArgs e)
        {
            var formHMacCalc = new frmHmac();
            formHMacCalc.Show();
        }

        private void rdbValidateFileWSimpleHash_Click(object sender, EventArgs e)
        {
            var formValidateFileWSimpleHash = new frmFileHashValidator();
            formValidateFileWSimpleHash.Show();
        }

        private void rdbtnValidateFileHmac_Click(object sender, EventArgs e)
        {
            var formValidateFileWHmac = new frmFilehmacvalidator();
            formValidateFileWHmac.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            grpBoxHome.Select();
        }

        
        
    }
}
