using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class NguoiThue
    {
        private string email;
        private string diaChi;
        private string sdt;
        private string ten;
        public NguoiThue(string email, string address, string phone, string name)
        {
            this.email = email;
            this.diaChi = address;
            this.sdt = phone;
            this.ten = name;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getDiaChi()
        {
            return this.diaChi;
        }
        public string getSdt()
        {
            return this.sdt;
        }
        public string getTen()
        {
            return this.ten;
        }
    }
}
