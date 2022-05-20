using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3
{
    public partial class frmBang : Form
    {
        public frmBang()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView_Click(object sender, EventArgs e)
        {
            if (lsvLichChieu.SelectedItems.Count > 0)
            {
                frmPhongChieu frm = new frmPhongChieu();
                this.Hide();
                frm.ShowDialog();
                this.OnLoad(null);
                this.Show();
            }
        }
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
