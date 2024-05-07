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
    public partial class FormDSPhongThue : Form
    {
        string strSql = @"Data Source=MSI;Initial Catalog=QLCH1;Integrated Security=True";
        SqlConnection sql = null;
        string ma;

        public FormDSPhongThue(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void FormDSPhongThue_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getAllHopDong().Tables[0];
            DataSet getAllHopDong()
            {
                DataSet dataSet = new DataSet();
                string querry = "select * from Phong_cho_thue";
                using (SqlConnection connection = new SqlConnection(strSql))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, connection);
                    adapter.Fill(dataSet);
                    connection.Close();
                }
                return dataSet;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trangchu f = new trangchu(ma);
            this.Hide();
            f.ShowDialog();
        }
    }
}
