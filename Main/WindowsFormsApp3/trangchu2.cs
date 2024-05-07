using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class trangchu2 : System.Windows.Forms.Form
    {
        string ma;
        public trangchu2(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void trangchu2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormThongTinKH f = new FormThongTinKH(ma);
            f.ShowDialog();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormThongTinKH f = new FormThongTinKH(ma);
            f.ShowDialog();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormNewHD f = new FormNewHD(ma);
            f.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormNewHD f = new FormNewHD(ma);
            f.ShowDialog();
            this.Hide();
        }
    }
}
