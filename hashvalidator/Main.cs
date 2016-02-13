using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;


namespace hashvalidator
{
    public partial class frmMain : Form
    {
        //Global Residents :)
        string FILE_TO_EVAL;

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the file to calculate the Hash for
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog objOpenFile = new OpenFileDialog();
            objOpenFile.Title = "Select a file to validate";
            if (objOpenFile.ShowDialog() == DialogResult.OK)
            {
                lblSelectedFileConfirmation.Text = objOpenFile.FileName.ToString();
                FILE_TO_EVAL = objOpenFile.FileName.ToString(); 
            }
            else
            {
                //Do nothing for now
            }           
        }

        

        /// <summary>
        /// Start the hash calculation process. Triggers when the user clicks on 
        /// "Validate the file" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateHash_Click(object sender, EventArgs e)
        {
            //Get the hash algorithm selected by the user
            // if nothing selected show a message to select one
            // Same for file to calculate the hash of
            if (cbHashAlgorithms.Text == "--Select--")
            {
                MessageBox.Show("Select a hash algorithm");
            }
            else if (String.IsNullOrEmpty(FILE_TO_EVAL))
            {
                MessageBox.Show("Select a file to verify");
            }
            //Everything is validated, so lets create an object of the Calculator Class
            ClassLibraries.calculator objCalculator = new ClassLibraries.calculator();
            string[] returnedCalculation = objCalculator.CalculateHash(FILE_TO_EVAL, cbHashAlgorithms.Text.ToString());

            if (string.Equals(returnedCalculation[0], "success"))
            {
                if (String.IsNullOrEmpty(txtHashValue.Text))
                {
                    txtResults.Text = returnedCalculation[1];
                }
                else if (String.Equals(returnedCalculation[1], txtHashValue.Text))
                {
                    txtResults.BackColor = System.Drawing.Color.Green;
                    txtResults.Text = "Valid File!!!";
                }
                else
                {
                    txtResults.BackColor = System.Drawing.Color.Red;
                    txtResults.Text = "Invalid File!!";
                }
            }
            else //This block executes when their is an error
            {
                MessageBox.Show(returnedCalculation[1]);
            }
        }

        private void keyedHashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formHMacCalc = new frmHmac();
            formHMacCalc.Show();
        }
    }
}
