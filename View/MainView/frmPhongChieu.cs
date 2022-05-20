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
    public partial class frmPhongChieu : Form
    {
        public frmPhongChieu()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void frmPhongChieu_Load(object sender, EventArgs e)
        {
            XuLyVeGhe();
        }

        private void XuLyVeGhe()
        {
            pnGhe.Controls.Clear();
            int Ghe = 1;
            for(int i=0; i<pnGhe.RowCount;i++)
            {
                for(int j =0; j<pnGhe.ColumnCount;j++)
                {
                    Label lblGhe = new Label();
                    lblGhe.Text = Ghe + "";
                    lblGhe.AutoSize = false;
                    lblGhe.Dock = DockStyle.Fill;
                    lblGhe.TextAlign = ContentAlignment.MiddleCenter;
                    pnGhe.Controls.Add(lblGhe, j, i);
                    lblGhe.BackColor = Color.White;
                    Ghe++;
                    lblGhe.Click += LblGhe_Click;
                }
            }
        }

        private void LblGhe_Click(object sender, EventArgs e)
        {
            Label lblGhe = sender as Label; 
            if(lblGhe.BackColor == Color.White)
            {
                lblGhe.BackColor = Color.Green;
            }    
            else if(lblGhe.BackColor == Color.Green)
            {
                lblGhe.BackColor = Color.White;
            }
            else if(lblGhe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế số [ " + lblGhe.Text +"] đã có người đặt"); 
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
