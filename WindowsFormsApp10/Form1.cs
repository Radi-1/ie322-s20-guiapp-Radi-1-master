using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class FrmMain : Form
    {

        string username = "Radi";
        string password = "12345";
        int attempt = 1;
        int maxattempts = 3;


        public FrmMain()
        {
            InitializeComponent();
        }

        private void BTNexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }
        
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            while (attempt <= maxattempts) 
            {
                if (TxtUser.Text != username) 

                {
                    MessageBox.Show("invalid username," + (maxattempts - attempt) + "attempt remaining");
                    TxtUser.Clear();

                    attempt++;
                    return;

                  
                }
                else
                {
                    if(TxtPassword.Text != "1234")
                    {
                        attempt++;
                        MessageBox.Show("incorrect password,"+ (maxattempts - attempt) + "attempt remaining");
                        TxtPassword.Clear();
                        return;

                    }
                      else
                    {
                        attempt = 0;
                        MessageBox.Show("Login successfull");
                        BtnLogin.Text = "Logout";
                        break;


                    }
                }
                 
                
                
                  

                



                





            }
                
                 
       
            
            
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            FrmCheck frm = new FrmCheck();
            frm.ShowDialog();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnPictureBox_Click(object sender, EventArgs e)
        {
            FrmPicture frm = new FrmPicture();
            frm.ShowDialog();
        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }
    }
}
