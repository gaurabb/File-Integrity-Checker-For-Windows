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
    public partial class frmFilehmacvalidator : Form
    {
        string FILE_TO_HMAC;
        string HMAC_ERROR = "Error calculating HMAC: Please try again";

        public frmFilehmacvalidator()
        {
            InitializeComponent();
        }

        private void btnBrowseFileToValidateHmac_Click(object sender, EventArgs e)
        {
            string selectedFile;
            OpenFileDialog objOpenFileToHmac = new OpenFileDialog();
            objOpenFileToHmac.Title = "Select a file to calculate HMAC";
            if (objOpenFileToHmac.ShowDialog() == DialogResult.OK)
            {
                selectedFile = objOpenFileToHmac.FileName.ToString();
                lblSelectedFileValue.Text = selectedFile;
                txtFileToValidateHmac.Text = selectedFile;
                FILE_TO_HMAC = selectedFile;
            }
        }

        private void btnValidateFileHmac_Click(object sender, EventArgs e)
        {
            //Validate that the following values are available:
            //1) HMAC algorithm is selected
            //2) File 
            //3) Key
            if (cmbHmacAlgo.Text == "--Select--" || String.IsNullOrEmpty(txtFileToValidateHmac.Text) || String.IsNullOrEmpty(txtHmacKey.Text))
            {
                MessageBox.Show("All the fields in RED must be selected!");
            }
            else
            {
                //Convert the key to a byte array
                byte[] _KEY_BYTES = new byte[0];
                // If all goes well, pass the values to the CalculateHMAC function in hashvalidator.ClassLibraries.calculator class
                // Too much input validation is intentionally avoided
                ClassLibraries.calculator objCalc = new ClassLibraries.calculator();
                string HMACResult = objCalc.CalculateHMAC(txtFileToValidateHmac.Text, cmbHmacAlgo.Text, _KEY_BYTES);
                if (!String.IsNullOrEmpty(HMACResult) && !String.Equals(HMACResult, HMAC_ERROR))
                {
                    txtHmacValidationResult.Text = HMACResult;
                }
                else
                {
                    MessageBox.Show(HMACResult);
                }
            }
        }
    }
}
