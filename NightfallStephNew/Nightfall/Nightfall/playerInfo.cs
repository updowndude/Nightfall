using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nightfall
{
    public partial class frmplayerInfo : Form
    {
        public frmplayerInfo()
        {
            InitializeComponent();
        }

        //user click the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            //hide thsi form
            this.Hide();
        }

        //user click the clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear the textboxs
            txtName.Clear();
            txtAllyone.Clear();
            txtAllyTwo.Clear();
            //puts the focus makes to textbox for the main chacter
            txtName.Focus();

            //uncheck boths radio buttons
            radMale.Checked = false;
            radFemale.Checked = false;
        }

        //user lick the go buttron
        private void btnGo_Click(object sender, EventArgs e)
        {
            //user if the check work
            bool blnFlag = false;

            //makes an copy of the forms
            frmConsole consoleCopy = new frmConsole();
            frmWelcomeScreen wScreen = new frmWelcomeScreen();

            //see if the frist text box is validated
            blnFlag = myCheck(txtName.Text,txtName);

            //then if it pass the text
            //same for the others
            if (blnFlag == true)
            {
                blnFlag = myCheckGender(radFemale.Checked, radMale.Checked);

                if (blnFlag == true)
                {
                    blnFlag = myCheck(txtAllyone.Text,txtAllyone);

                    if (blnFlag == true)
                    {
                        blnFlag = myCheck(txtAllyTwo.Text,txtAllyTwo);

                        if(blnFlag == true)
                        {
                            //close the welcome screen
                            wScreen.Close();

                            //show the console form
                            consoleCopy.Show();

                            //hides the form
                            this.Hide();

                            //sets the patry names and main chacter gender
                            consoleCopy.strMyText = txtName.Text;
                            consoleCopy.strAllyOneName = txtAllyone.Text;
                            consoleCopy.strAllyTwoName = txtAllyTwo.Text;
                            consoleCopy.blnGender = radFemale.Checked;
                        }
                    }
                }
            }
        }

        //form is loaded
        private void frmplayerInfo_Load(object sender, EventArgs e)
        {
            //foucs the textbox for the main chacter
            txtName.Focus();
        }

        //handels the check
        private bool myCheck(String strText,TextBox txtError)
        {
            //what the check
            bool blnCheck = true;

            //if theres an space
            int intSpace = 0;

            //removes space form the user enter only the beging and end
            string strMyText = strText.Trim();

            //makes a list of chacter form there text
            char[] charAryText = strMyText.ToCharArray();

            //finds a space in name
            intSpace = strMyText.IndexOf(" ");

            //something was entred
            if (strMyText.Length != 0)
            {
                //walks thorught the word
                for (int lcv = 0; lcv < strText.Length; lcv++)
                {
                    //if theres an space
                    if (intSpace < 0)
                    {
                        //something wasn't an letter
                        if (!char.IsLetter(strText[lcv]))
                        {
                            //error happend
                            blnCheck = ErrorHappen("Name most have some letters",txtError);
                            //stops the loop
                            break;
                        }
                    }
                    //there is spaces
                    else
                    {
                        //skips the spaces
                        if (charAryText[lcv] != ' ')
                        {
                            //same check as before
                            if (!char.IsLetter(strText[lcv]))
                            {
                                blnCheck = ErrorHappen("Name most have some letters",txtError);
                                break;
                            }
                        }
                    }
                }
            }
            //not text was enterd
            else
            {
                //error happend and place foucs on that textbox
                blnCheck = ErrorHappen("Name most have some letters",txtError);
            }

            //get back if check worked
            return blnCheck;
        }

        //checks the gender
        private bool myCheckGender(bool blnRadF, bool blnRadM)
        {
            //nothing was click for the radio buttons
                if ((blnRadF == false) && (blnRadM == false))
                {
                //display an message
                    MessageBox.Show("Please select a gender");
                //get back that the check fails
                return false;
                }
                //check pased
                else
            {
                //get back theat check passs
                return true;
            }

        }

        //error happend
        private bool ErrorHappen(string strText, TextBox txtError)
        {
            //focus that textboxc
            txtError.Focus();
            //select all of the text in insdie that textboxc
            txtError.SelectAll();

            //display an message about what when wrong
            MessageBox.Show(strText);
            return false;
        }
    
    }
}
