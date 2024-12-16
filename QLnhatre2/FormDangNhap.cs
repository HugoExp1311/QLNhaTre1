using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLnhatre2
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kiểm tra thông tin đăng nhập theo vai trò
            if (username == "GVien01" && password == "gv123")
            {
                MessageBox.Show("Đăng nhập thành công với vai trò Giáo Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var teacherForm = new Form1(); // Form dành cho Giáo Viên
                teacherForm.ShowDialog();
                this.Show();
            }
            else if (username == "GVu01" && password == "gv456")
            {
                MessageBox.Show("Đăng nhập thành công với vai trò Giáo Vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                // var adminForm = new AdminForm(); 
               // adminForm.ShowDialog();
                this.Show();
            }
            else if (username == "KT01" && password == "kt123")
            {
                MessageBox.Show("Đăng nhập thành công với vai trò Kế Toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            //    var accountantForm = new KeToan(); // Form dành cho Kế Toán
            //    accountantForm.ShowDialog();
                this.Show();
            }
             else if (username == "NS01" && password == "ns123")
            {
                MessageBox.Show("Đăng nhập thành công với vai trò Nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            //    var hrForm = new QuanLyNhanSu(); // Form dành cho Kế Toán
            //    hrForm.ShowDialog();
                this.Show();
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
        }
    