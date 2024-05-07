using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class quenMK : System.Windows.Forms.Form
    {
        public quenMK()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Nhập mật khẩu mới";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar = '\0';
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "example@gmail.com")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "example@gmail.com";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Nhập mật khẩu mới")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Xác nhận mật khẩu")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                textBox3.PasswordChar = '*';

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Xác nhận mật khẩu";
                textBox3.ForeColor = Color.Silver;
                textBox3.PasswordChar = '\0';
            }
        }

        private bool isEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string strRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex regex = new Regex(strRegex);
            return regex.IsMatch(email);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            CloseAllForms();
        }

        

        private bool IsPasswordValid(string password, int minLength)
        {
            // Kiểm tra độ dài của mật khẩu
            if (password.Length < minLength)
                return false;

            // Kiểm tra mật khẩu có chứa ít nhất một ký tự chữ thường
            if (!password.Any(char.IsLower))
                return false;

            // Kiểm tra mật khẩu có chứa ít nhất một ký tự chữ hoa
            if (!password.Any(char.IsUpper))
                return false;

            // Kiểm tra mật khẩu có chứa ít nhất một ký tự số
            if (!password.Any(char.IsDigit))
                return false;

            // Kiểm tra mật khẩu có chứa ít nhất một ký tự đặc biệt
            string specialCharsPattern = @"[!@#$%^&*()\-_=+[\]{}|;:',.<>?]";
            if (!Regex.IsMatch(password, specialCharsPattern))
                return false;

            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            check2();
        }

        public void check2()
        {
            if (!isEmail(textBox1.Text))
            {
                MessageBox.Show(this, "Email bị lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox4.Text.Length != 10)
            {
                MessageBox.Show(this, "Số điện thoại bị lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!IsPasswordValid(textBox2.Text, 8))
            {
                MessageBox.Show(this, "Mật khẩu ít nhất 8 ký tự, phải có một ký tự viết thường, một ký tự viết hoa, một ký tự số và một ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show(this, "Nhập lại mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=AN;Initial Catalog=QLCH2;Integrated Security=True");
                con.Open();
                String sql1 = "select * from Nguoi_thue where So_dien_thoai  = '" + textBox4.Text + " ' and email = '" + textBox1.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlDataReader rdr1 = cmd1.ExecuteReader();
                if (!rdr1.Read())
                {   
                    rdr1.Close();
                }
                else
                {
                    Random r = new Random();
                    int code = r.Next(1000, 10000);
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("thuanminh1390@gmail.com");
                    mail.To.Add(textBox1.Text.Trim());
                    mail.Subject = "Mã Xác Nhận";
                    mail.Body = Convert.ToString(code);

                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential("thuanminh1390@gmail.com", "efrn boew pxah cwhh");
                    smtpClient.EnableSsl = true;
                    try
                    {
                        smtpClient.Send(mail);
                        MessageBox.Show(this, "Đã gửi mã xác nhận về email của bạn, vui lòng nhập mã xác nhận để đổi mật khẩu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        checkCode ck = new checkCode(code, textBox3.Text, textBox4.Text, textBox1.Text);
                        ck.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void quenMK_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Số điện thoại")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Số điện thoại";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                pictureBox5.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                pictureBox6.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '*')
            {
                pictureBox7.BringToFront();
                textBox3.PasswordChar = '\0';
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '\0')
            {
                pictureBox9.BringToFront();
                textBox3.PasswordChar = '*';
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        static void CloseAllForms()
        {
            // Lấy danh sách tất cả các Form đang mở
            FormTongTien[] openForms = Application.OpenForms.Cast<FormTongTien>().ToArray();

            // Đóng tất cả các Form
            foreach (System.Windows.Forms.Form form in openForms)
            {
                form.Close();
            }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                check2();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                check2();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                check2();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                check2();
            }
        }
    }
}
