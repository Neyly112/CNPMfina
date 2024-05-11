using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormHuyHopDong : Form
    {
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;
        string tenNguoiThue;
        string ma;
        string tenPhong;
        string soNg;
        string ngayBD;
        string ngayKT;
        string maNguoiThue;

        public FormHuyHopDong(string ma, string tenPhong, string soNg, string ngayBD, string ngayKT, string maNguoiThue)
        {
            InitializeComponent();
            this.ma = ma;
            this.tenPhong = tenPhong;
            this.soNg = soNg;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
            this.maNguoiThue = maNguoiThue;
            strSql = c.SqlConect();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTimPhong_Click(object sender, EventArgs e)
        {

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDanhSachHopDong f = new FormDanhSachHopDong(ma);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
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
            sqlCm.CommandText = "delete from Hop_dong where MaPhong= '" + tenPhong + "'";
            funcDeletePhongThue();
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Đã hủy hợp đồng");
            }
            else
            {
                MessageBox.Show("Hợp đồng không tồn tại");
            }
            this.Hide();
            FormDanhSachHopDong f = new FormDanhSachHopDong(ma);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (dateTimePicker2 == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                return;
            }
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
            sqlCm.CommandText = "update Hop_dong set NgayKetThuc = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', SoNguoiO='" + tbSoNg.Text.Trim() + "' where MaPhong = '" + tenPhong + "'";
            sqlCm.Connection = sql;
            funcDoiTenNguoiThue(tenPhong);
            int kq = sqlCm.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Sửa thông tin thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }


        private void funcDoiTenNguoiThue(string maPhong)
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
            sqlCm.CommandText = "update Nguoi_thue set Ten = N'" + tbTenNguoiThue.Text.Trim() + "' where MaNguoiThue = '" + maNguoiThue + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            
        }
        private void funcDeletePhongThue()
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
            sqlCm.CommandText = "delete from Phong_thue_so_huu where MaPhong= '" + tenPhong + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
        }
        private void FormHuyHopDong_Load(object sender, EventArgs e)
        {
            funcGetTenNguoiThue();
            tbTenNguoiThue.Text = tenNguoiThue;
            tbTenPhong.Text = tenPhong;
            dateTimePicker1.Text = ngayBD;
            dateTimePicker2.Text = ngayKT;
            tbSoNg.Text = soNg;
        }

        
        private void lbNgayKetThuc_Click(object sender, EventArgs e)
        {
            
        }

        private void lbTenNguoiThue_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnTimPhong_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
        }
    }
}
