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
    public partial class FormNhapTinhToan : System.Windows.Forms.Form
    {
        string ma;
        string maCanHo;
        string[] xe = new string[100];
        int xeMay = 0;
        int xeDap = 0;
        int xe_duoi_1_5_tan = 0;
        int countXe = 0;
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;

        public FormNhapTinhToan(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tbMaCanHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void getXe()
        {

            string tmp;
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
            sqlCm.CommandText = "exec xemXe";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                tmp = reader.GetString(0).ToString();
                xe[i] = tmp;
                i++;
                countXe++;
            }
            reader.Close();

        }

        private void FormNhapTinhToan_Load(object sender, EventArgs e)
        {
            getXe();

            for (int i = 0; i < countXe; i++)
            {
                if (xe[i] == "xe may")
                {
                    xeMay++;
                }
                else if (xe[i] == "xe dap")
                {
                    xeDap++;
                }
                else if (xe[i] == "xe duoi 1,5 tan")
                {
                    xe_duoi_1_5_tan++;
                }
            }
        }
        private void funcTinhTien(double so_m3, double soKwh, string maPhong)
        {
            double phiNuoc;
            double phiSinhHoatt;
            double phiDien;
            string maCanHo = maPhong;
            string maBangPhi;
            double tongTien;
            double tongTienNuoc;
            double tongTienDien;
            double tongTienXe;
            double phiXeDap;
            double phiXeMay;
            double phiXe15Tan;
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
            sqlCm.CommandText = "select top 1 * from Bang_phi order by MaBangPhi desc";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {

                phiNuoc = reader.GetDouble(0);

                phiSinhHoatt = reader.GetDouble(1);

                phiDien = reader.GetDouble(2);

                phiXeMay = reader.GetDouble(3);

                phiXeDap = reader.GetDouble(4);

                phiXe15Tan = reader.GetDouble(5);

                tongTienXe = phiXeMay * xeMay + phiXeDap * xeDap + phiXe15Tan * xe_duoi_1_5_tan;
                tongTienDien = soKwh * phiDien;
                tongTienNuoc = so_m3 * phiNuoc;
                tongTien = so_m3 * phiNuoc + phiSinhHoatt + soKwh * phiDien + tongTienXe;
                maBangPhi = reader.GetString(6);

                FormTongTien f = new FormTongTien(maCanHo, tongTienNuoc, tongTienDien, phiSinhHoatt, tongTien, maBangPhi, ngayBatDau.Text.Trim(), so_m3, soKwh, xeMay, xeDap, xe_duoi_1_5_tan, tongTienXe);
                f.ShowDialog();

            }

        }
        private void ngayBatDau_ValueChanged(object sender, EventArgs e)
        {
            ngayBatDau.Format = DateTimePickerFormat.Custom;
            ngayBatDau.CustomFormat = "yyyy-MM-dd";
        }

        private void ngayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            ngayKetThuc.Format = DateTimePickerFormat.Custom;
            ngayKetThuc.CustomFormat = "yyyy-MM-dd";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            trangchu t = new trangchu(ma);
            t.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if ((tbMaCanHo.Text == "") || (tbTienDien.Text == "") || (tbMaCanHo.Text == "") || (tbTienNuoc.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if ((checkPhong(tbMaCanHo.Text.Trim()) == false) || (checkPhongDaThue(tbMaCanHo.Text.Trim()) == false))
            {
                MessageBox.Show("Phòng đã cho thuê hoặc không tồn tại");
                return;
            }
            string maPhong = tbMaCanHo.Text.Trim();
            double so_m3 = Convert.ToDouble(tbTienNuoc.Text.Trim());
            double soKwh = Convert.ToDouble(tbTienDien.Text.Trim());
            funcTinhTien(so_m3, soKwh, maPhong);
        }

        private void tbMaCanHo_TextChanged_1(object sender, EventArgs e)
        {

        }
        private bool checkPhong(string maPhong)
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
            sqlCm.CommandText = "select * from Phong_cho_thue where MaPhong= '" + maPhong + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            int kq = 0;
            while (reader.Read())
            {
                kq = 1;
            }
            reader.Close();
            if (kq == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool checkPhongDaThue(string maPhong)
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
            sqlCm.CommandText = "select * from Phong_thue_so_huu where MaPhong= '" + maPhong + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            int kq = 0;
            while (reader.Read())
            {
                kq = 1;
            }
            reader.Close();
            if (kq == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
