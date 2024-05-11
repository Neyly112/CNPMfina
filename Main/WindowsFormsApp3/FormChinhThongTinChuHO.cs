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
    public partial class FormChinhThongTinChuHO : Form
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
        public FormChinhThongTinChuHO(string ma, string ten, string matKhau, string diaChi, string email, string sDT)
        {
            InitializeComponent();
            this.ma = ma;
            this.ten = ten;
            this.sDT = sDT;
            this.email = email;
            this.matKhau = matKhau;
            this.diaChi = diaChi;
            strSql = c.SqlConect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinChuHo f = new FormThongTinChuHo(ma);
            f.ShowDialog();
        }

        private void FormChinhThongTinChuHO_Load(object sender, EventArgs e)
        {
            tbDiaChi.Text = diaChi;
            tbEmail.Text = email;
            tbTen.Text = ten;
            tbSdt.Text = sDT;
            tbMk.Text = matKhau;
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
            sqlCm.CommandText = "Update Chu_ho set DiaChi=N'" + diaChi + "', SoDienThoai='" + Sdt + "', Email='" + email + "', Ten= N'" + ten + "', MatKhau= N'" + matKhau + "' where MaChuHo= '" + ma + "'";
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
            FormThongTinChuHo f = new FormThongTinChuHo(ma);
            f.ShowDialog();
        }
    }
}
