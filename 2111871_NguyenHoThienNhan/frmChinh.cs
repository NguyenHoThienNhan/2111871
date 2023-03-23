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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {

        }

        private void bài35ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLinkLabel frm = new frmLinkLabel();
            frm.ShowDialog();
        }

        private void bài42ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubmit frm = new frmSubmit();
            frm.ShowDialog();
        }

        private void bài48ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDemoComboBox frm = new frmDemoComboBox();
            frm.ShowDialog();
        }

        private void bài52ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBoxs frm = new frmListBoxs();
            frm.ShowDialog();
        }

        private void bàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDemoRadioButton frm = new frmDemoRadioButton();
            frm.ShowDialog();
        }

        private void bìa57ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmButtons frm = new frmButtons();
            frm.ShowDialog();
        }

        private void bài60ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDemoCheckListBox frm = new frmDemoCheckListBox();
            frm.ShowDialog();
        }
    }
}
