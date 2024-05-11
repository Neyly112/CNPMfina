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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp3
{
    public partial class FormChinhThongTinKH : Form
    {
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;
        string ma;
        string ten;
        string diaChi;
        string sDT;
        string email;
        string matKhau;
        public FormChinhThongTinKH(string ma, string ten, string diaChi, string sDT, string email, string matKhau)
        {
            InitializeComponent();
            this.ma = ma;
            this.ten = ten;
            this.matKhau = matKhau;
            this.sDT = sDT;
            this.email = email;
            this.diaChi = diaChi;
            strSql = c.SqlConect();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ten = tbTen.Text.Trim();
            string Sdt = tbSdt.Text.Trim();
            string email = tbEmail.Text.Trim();
            string diaChi = tbDiaChi.Text.Trim();
            string matKhau = tbMk.Text.Trim();
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
            sqlCm.CommandText = "Update Nguoi_thue set DiaChi=N'" + diaChi + "', SoDienThoai='" + Sdt + "', Email='" + email + "', Ten= N'" + ten + "', MatKhau= N'" + matKhau + "' where MaNguoiThue= '" + ma + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Đã sửa thông tin");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            this.Hide();
            FormThongTinKH f = new FormThongTinKH(ma);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinKH f = new FormThongTinKH(ma);
            f.ShowDialog();
        }

        private void tbDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbMk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormChinhThongTinKH_Load(object sender, EventArgs e)
        {
            tbDiaChi.Text = diaChi;
            tbEmail.Text = email;
            tbTen.Text = ten;
            tbSdt.Text = sDT;
            tbMk.Text = matKhau;
        }
    }
}
