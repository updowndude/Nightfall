using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nightfall
{
    public partial class frmWelcomeScreen : Form
    {
        //plays an sound
        System.Media.SoundPlayer soPLfightItOut = new System.Media.SoundPlayer(@"TWIST_A.wav");

        public frmWelcomeScreen()
        {
            InitializeComponent();
        }

        //loads the form
        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            //plays the sound
            soPLfightItOut.PlayLooping();
        }

        //user mosue over
        //same for the ohters
        private void btnNewGame_MouseHover(object sender, EventArgs e)
        {
            //changes the color to white
            btnNewGame.ForeColor = System.Drawing.Color.White;
        }

        private void btnLoadGame_MouseHover(object sender, EventArgs e)
        {
            btnLoadGame.ForeColor = System.Drawing.Color.White;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.ForeColor = System.Drawing.Color.White;
        }
        //user click the close button
        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            Nightfall.frmWelcomeScreen.ActiveForm.Close(); 
        }

        //user click the new game button
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //makes an copy of player info
            frmplayerInfo fPlayerInfo = new frmplayerInfo();
            //show that form
            fPlayerInfo.ShowDialog();
            //hide this form
            this.Hide();
        }

        //user click the load game
        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            //makes an copy okf console form
            frmConsole fConsole = new frmConsole();

            //see if it works
            try
            {
                //opens the file dialog
                ofdLoad.ShowDialog();
                //sets that file name to value on other form
                fConsole.strload = ofdLoad.FileName;
            }
            //some thing when work
            catch (Exception ex)
            {
                MessageBox.Show("sorry some things is wrong with our save");
            }

            //shows the other form
            fConsole.Show();
            //hide thsi form
            this.Hide();
        }

        //user mouse leave the button
        private void btnNewGame_MouseLeave(object sender, EventArgs e)
        {
            //changes the color backt to red
            btnNewGame.ForeColor = System.Drawing.Color.Red;
        }

        private void btnLoadGame_MouseLeave(object sender, EventArgs e)
        {
            btnLoadGame.ForeColor = System.Drawing.Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = System.Drawing.Color.Red;
        }
    }
}
