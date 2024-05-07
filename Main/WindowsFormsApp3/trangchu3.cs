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
    public partial class trangchu3 : System.Windows.Forms.Form
    {
        string ma;
        public trangchu3(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FormDieuChinhPhi formDieuChinhPhi = new FormDieuChinhPhi(ma);
            formDieuChinhPhi.ShowDialog();
            this.Hide();
        }

        private void trangchu3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinChuHo f = new FormThongTinChuHo(ma);
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinChuHo f = new FormThongTinChuHo(ma);
            f.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormDSHDCH f = new FormDSHDCH(ma);
            f.ShowDialog();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormDSHDCH f = new FormDSHDCH(ma);
            f.ShowDialog();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDieuChinhPhi formDieuChinhPhi = new FormDieuChinhPhi(ma);
            formDieuChinhPhi.ShowDialog();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FormDSPhongThue f = new FormDSPhongThue(ma);
            f.ShowDialog();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormDSPhongThue f = new FormDSPhongThue(ma);
            f.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormDSHDCH f = new FormDSHDCH(ma);
            f.ShowDialog();
            this.Hide();
        }
    }
}
