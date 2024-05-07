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
    public partial class FormThongTinChuHo : Form
    {
        string strSql = @"Data Source=MSI;Initial Catalog=QLCH1;Integrated Security=True";
        SqlConnection sql = null;
        string ma;
        string matKhau;
        string diaChi;
        string sDT;
        string email;
        string ten;
        public FormThongTinChuHo(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void FormThongTinChuHo_Load(object sender, EventArgs e)
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

            sqlCm.CommandText = "select * from Chu_ho where MaChuHo='" + ma + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                matKhau = reader.GetString(4);
                diaChi = reader.GetString(1);
                sDT = reader.GetString(3);
                email = reader.GetString(2);
                ten = reader.GetString(0);
                lbTen.Text = ten;
                lbDiaChi.Text = diaChi;
                lbEmail.Text = email;
                lbMatKhau.Text = matKhau;
                lbSdt.Text = sDT;
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChinhThongTinChuHO f = new FormChinhThongTinChuHO(ma, ten, matKhau, diaChi, email, sDT);
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu3 f = new trangchu3(ma);
            f.ShowDialog();
        }
    }
}
