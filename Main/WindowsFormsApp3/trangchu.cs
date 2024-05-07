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
    public partial class trangchu : System.Windows.Forms.Form
    {
        string ma;
        public trangchu(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormNhapTinhToan f = new FormNhapTinhToan(ma);
            f.ShowDialog();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trangchu_Load(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FormDanhSachHopDong f = new FormDanhSachHopDong(ma);
            this.Hide();
            f.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormDanhSachHopDong f = new FormDanhSachHopDong(ma);
            this.Hide();
            f.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormDanhSachHopDong f = new FormDanhSachHopDong(ma);
            this.Hide();
            f.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNhapTinhToan f = new FormNhapTinhToan(ma);
            f.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSBangPhi f = new FormDSBangPhi(ma);
            f.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinQuanLy f = new FormThongTinQuanLy(ma);
            f.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormDSBangPhi f = new FormDSBangPhi(ma);
            f.ShowDialog();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormDSBangPhi f = new FormDSBangPhi(ma);
            f.ShowDialog();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            FormDSPhongThue f = new FormDSPhongThue(ma);
            f.ShowDialog();
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
    }
}
