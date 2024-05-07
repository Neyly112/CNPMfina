using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormXacNhanHD : Form
    {
        string strSql = @"Data Source=MSI;Initial Catalog=QLCH1;Integrated Security=True";
        SqlConnection sql = null;
        string tenNguoiThue;
        string ma;
        string tenPhong;
        string soNg;
        string ngayBD;
        string ngayKT;
        string maNguoiThue;

        public FormXacNhanHD(string ma, string tenPhong, string soNg, string ngayBD, string ngayKT, string maNguoiThue)
        {
            InitializeComponent();
            this.ma = ma;
            this.tenPhong = tenPhong;
            this.soNg = soNg;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
            this.maNguoiThue = maNguoiThue;

        }

        private void FormXacNhanHD_Load(object sender, EventArgs e)
        {
            funcGetTenNguoiThue();
            MessageBox.Show(tenNguoiThue);
            MessageBox.Show(tenPhong);
            tbTenNguoiThue.Text = tenNguoiThue;
            tbTenPhong.Text = tenPhong;
            dateTimePicker1.Text = ngayBD;
            dateTimePicker2.Text = ngayKT;
            tbSoNg.Text = soNg;
        }

        private void funcGetTenNguoiThue()
        {
            if (sql == null)
            {
                sql = new SqlConnection(strSql);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }

            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "exec getTenNguoiThue '" + tenPhong + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                string tmp = reader.GetString(0);
                tenNguoiThue = tmp;

            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcUpdateTrangThaiHD();
            funcUpdateTrangThaiPhong();
            MessageBox.Show("Đã xác nhận");
        }

        private void funcUpdateTrangThaiPhong()
        {
            if (sql == null)
            {
                sql = new SqlConnection(strSql);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }

            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "Update Phong_cho_thue set TrangThaiPhong=N'Đã thuê' where MaPhong= '" + tenPhong + "'";
            sqlCm.Connection = sql;
            sqlCm.ExecuteNonQuery();
        }
        private void funcUpdateTrangThaiHD()
        {
            if (sql == null)
            {
                sql = new SqlConnection(strSql);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }

            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "Update Hop_dong set TrangThai=N'Đã xác nhận' where Ma_phong= '" + tenPhong + "'";
            sqlCm.Connection = sql;
            sqlCm.ExecuteNonQuery();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSHDCH f = new FormDSHDCH(ma);
            f.ShowDialog();
        }
    }
}
