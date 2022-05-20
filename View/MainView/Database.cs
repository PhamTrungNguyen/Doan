//using pbl3.DAO;
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
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }
        public static string DataSource;
        public static string InitialCatalog;
        public static string UserID;
        public static string pwd;
        public static string connectionSTR;
        //DataProvider data = new DataProvider();
        private void btnLuuKetNoi_Click(object sender, EventArgs e)
        {
            //btnLuuKetNoi.Enabled = false;
            //btnDataThoat.Enabled = false;
            //if (txtPassword.Text != "")
            //{
            //    connectionSTR = "Data Source=" + txtserverName.Text
            //        + ";Initial Catalog=" + txtdataName.Text
            //        + ";User ID=" + txtuserName.Text
            //        + ";pwd=" + txtPassword.Text;
            //}
            //else
            //{
            //    connectionSTR = "Data Source= " + txtserverName.Text
            //        + ";Initial Catalog=" + txtdataName.Text
            //        + ";Integrated Security=True";
            //    connectionSTR = @"Data Source= TRUNG-NGUYEN\SQLEXPRESS"
            //       + ";Initial Catalog= nam3"
            //       + ";Integrated Security=True";
            //}
            //bool result = data.ConnectionSQL(connectionSTR);
            //if (result)
            //{
            //    MessageBox.Show("KẾT NỐI THÀNH CÔNG", "THÔNG BÁO");
            //}
            //else
            //    MessageBox.Show("KẾT NỐI THẤT BẠI", "THÔNG BÁO");
            //btnLuuKetNoi.Enabled = true;
            //btnDataThoat.Enabled = true;
        }
    }
}
