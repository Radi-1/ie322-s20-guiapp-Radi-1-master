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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
            CmbDays.Items.Add("sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("wdnesday");
            CmbDays.Items.Add("thursday");
            CmbDays.Items.Add("friday");
            CmbDays.Items.Add("saturday");


        }

        private void BtnShowM1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);
        }

        private void Btn2nd_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("cant remove last item");
            }

        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)
            
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("cant remove last item");
            }

        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("friday");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnIndex_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);
        }
    }
}
