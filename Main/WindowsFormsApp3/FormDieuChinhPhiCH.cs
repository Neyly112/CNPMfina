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
    public partial class FormDieuChinhPhiCH : Form
    {
        string ma;
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;
        

        public FormDieuChinhPhiCH(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbPhiSinhHoat.Text == "" || tbTienDien.Text == "" ||
               tbTienNuoc.Text == "" || tbTienXeMay.Text == "" ||
               tbTienXeDap.Text == "" || tbTienXe15Tan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
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

            string tienNuoc = tbTienNuoc.Text.Trim();
            string tienDien = tbTienDien.Text.Trim();
            string phiSinhHoat = tbPhiSinhHoat.Text.Trim();
            string tienXeMay = tbTienXeMay.Text.Trim();
            string tienXeDap = tbTienXeDap.Text.Trim();
            string tienXeDuoi15Tan = tbTienXe15Tan.Text.Trim();
            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "exec insertToBP '" + tienNuoc + "', '" + phiSinhHoat + "', '" +
            tienDien + "', '" + tienXeMay + "', '" + tienXeDap + "', '" + tienXeDuoi15Tan + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Chỉnh sửa thành công");
            }
            else
            {
                MessageBox.Show("Loi");
            }
            this.Hide();
            FormDSBP f = new FormDSBP(ma);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSBP f = new FormDSBP(ma);
            f.ShowDialog();
        }

        private void FormDieuChinhPhiCH_Load(object sender, EventArgs e)
        {

        }
    }
}
