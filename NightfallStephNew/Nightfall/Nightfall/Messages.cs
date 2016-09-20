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
    public partial class frmMessages : Form
    {
        //show different parts of the form
        //same for the others
        bool _blnClear = false;
        bool _blnTextBox = false;
        bool _blnRiddle = false;
        bool _blnLabelRidde = false;
        bool _blnExit = false;

        //what the message should display
        string _strMessage = "";

        //others class can effect what some value are
        //same for other
        public string strMessage
        {
            set { _strMessage = value;  }
        }

        public bool blnClear
        {
            set { _blnClear = value; }
        }

        public bool blnTextBox
        {
            set { _blnTextBox = value; }
        }

        public bool blnRiddle
        {
            set { _blnRiddle = value; }
        }

        public bool blnLabelRiddle
        {
            set { _blnLabelRidde = value; }
        }

        public bool blnExit
        {
            set { _blnExit = value; }
        }

        public frmMessages()
        {
            InitializeComponent();
        }

        //user click the close button
        private void btnExit_Click(object sender, EventArgs e)
        {
            //close that form
            this.Close();
        }

        //user click the clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear what user has type into the textbox
            txtGuess.Clear();
            //puts the foucs on that textbox
            txtGuess.Focus();
        }

        //user click go button
        private void btnGo_Click(object sender, EventArgs e)
        {
            //makes an copy of console form
            frmConsole fConsole = new frmConsole();

            //if this is open for the riddle
            if (btnExit.Visible == true)
            {
                //makes sure the user as input some thing for the= ansewer
                if (txtGuess.Text.Trim() == "")
                {
                    //set answer on to console form
                    fConsole.strAnswer = txtGuess.Text.ToLower().Trim();
                    //hides this form
                    this.Hide();
                }
                //nothing was entered
                else
                {
                    //foucs the textbox
                    txtGuess.Focus();
                    //select all of the there text
                    txtGuess.SelectAll();
                    //display a mesage
                    MessageBox.Show("Whats your answer");
                }
            }
            //not used for the riddel
            else
            {
                //close this form
                this.Hide();
            }
        }

        private void frmMessages_Shown(object sender, EventArgs e)
        {
            //makes an list on senestence 
            string[] aryStrWords = _strMessage.Split('.','!','?');

            //sets what items should be shown
            btnClear.Visible = _blnClear;
            txtGuess.Visible = _blnTextBox;
            lsbRiddle.Visible = _blnRiddle;
            lblRiddle.Visible = _blnLabelRidde;
            btnExit.Visible = _blnExit;

            //walks throught the list
            for(int lcv=0;lcv<aryStrWords.Length;lcv++)
            {
                //fills out the list box
                lsbRiddle.Items.Add(aryStrWords[lcv]);
            }
        }
    }
}
