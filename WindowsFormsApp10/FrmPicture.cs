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
    public partial class FrmPicture : Form
    {

        
     public FrmPicture()
        {
            InitializeComponent();
        }

        private void BtnImageFromResource_Click(object sender, EventArgs e)
        {
            
            

              
            
        }

        private void FrmPicture_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnImageFromFile_Click(object sender, EventArgs e)
        {
            Pic01.Image = Image.FromFile("C://Users//welcome//Pictures// KAU");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
