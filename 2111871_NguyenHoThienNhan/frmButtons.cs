using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2111871_NguyenHoThienNhan
{
    public partial class frmButtons : Form
    {
        public frmButtons()
        {
            InitializeComponent();
        }
        private void ckbMauChu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMauChu.Checked)
                this.btnButton.ForeColor = Color.Red;
            else
                this.btnButton.ForeColor = Color.Black;
        }

        private void ckbMauNen_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMauNen.Checked)
                this.btnButton.BackColor = Color.LightCyan;
            else
                this.btnButton.BackColor = this.btnFlat.BackColor;
        }

        private void rdFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdFlat.Checked)
                this.rdFlat.FlatStyle = FlatStyle.Flat;
            else
                this.rdFlat.FlatStyle = FlatStyle.Popup;
        }
    }
}
