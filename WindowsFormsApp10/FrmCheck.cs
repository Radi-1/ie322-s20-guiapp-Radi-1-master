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
    public partial class FrmCheck : Form
    {
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (ChkaCoffee.Checked ==true)
            {
                msg = ChkaCoffee.Text;
            }

            if (ChkDonut.Checked == true)
            {
                msg = msg + "" + ChkDonut.Text;
            }

            if (ChkBrownie.Checked == true)
            {
                msg = msg + "" + ChkBrownie.Text;
            }
            
            // Now Display the order
            if (msg.Length > 0)
            {
                MessageBox.Show(msg + "ordered.");
            }
            else // length is zero 
            {
                MessageBox.Show("Nothing ordered,sir/MmE");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
