﻿using System;
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
    public partial class FormThongTinQuanLy : Form
    {
        string strSql = @"Data Source=MSI;Initial Catalog=QLCH1;Integrated Security=True";
        SqlConnection sql = null;
        string ma;
        string matKhau;
        string diaChi;
        string sDT;
        string email;
        string ten;
        public FormThongTinQuanLy(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu trangchu = new trangchu(ma);
            trangchu.ShowDialog();
        }

        private void FormThongTinQuanLy_Load(object sender, EventArgs e)
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
          
            sqlCm.CommandText = "select * from Quan_li where MaQuanLi='" + ma + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                matKhau = reader.GetString(0);
                diaChi = reader.GetString(1);
                sDT = reader.GetString(3);
                email = reader.GetString(4);
                ten = reader.GetString(5);
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

            FormChinhSuaThongTinQL f = new FormChinhSuaThongTinQL(ma, ten, diaChi, email, matKhau, sDT);
            f.ShowDialog();
            this.Hide();
        }
    }
}