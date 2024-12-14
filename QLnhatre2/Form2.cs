using System;
using System.Windows.Forms;
using QLnhatre2.BLL;

namespace QLnhatre2
{
    public partial class Form2 : Form
    {
        private readonly StudentBLL studentBLL;
        public Form2()
        {

            InitializeComponent();
            studentBLL = new StudentBLL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string studentCode = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(studentCode))
            {
                MessageBox.Show("Vui lòng nhập mã trẻ em.");
                return;
            }

            try
            {
                // Lấy trạng thái hiện tại
                string currentStatus = studentBLL.GetStudentStatus(studentCode);

                if (currentStatus == null)
                {
                    MessageBox.Show("Không tìm thấy học sinh có mã: " + studentCode);
                    return;
                }

                // Đổi trạng thái giữa "có mặt" và "vắng mặt"
                string newStatus = currentStatus == "có mặt" ? "vắng mặt" : "có mặt";

                bool isUpdated = studentBLL.UpdateStudentStatus(studentCode, newStatus);

                if (isUpdated)
                {
                    //lblStatus.Text = $"Trạng thái mới: {newStatus}";
                    MessageBox.Show("Cập nhật trạng thái thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string studentCode = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(studentCode))
            {
                MessageBox.Show("Vui lòng nhập mã trẻ em.");
                return;
            }

            try
            {
                // Lấy trạng thái hiện tại
                string currentStatus = studentBLL.GetStudentStatus(studentCode);

                if (currentStatus == null)
                {
                    MessageBox.Show("Không tìm thấy học sinh có mã: " + studentCode);
                    return;
                }

                // Đổi trạng thái giữa "có mặt" và "vắng mặt"
                string newStatus = currentStatus == "vắng mặt" ? "có mặt" : "vắng mặt";

                bool isUpdated = studentBLL.UpdateStudentStatus(studentCode, newStatus);

                if (isUpdated)
                {
                    //lblStatus.Text = $"Trạng thái mới: {newStatus}";
                    MessageBox.Show("Cập nhật trạng thái thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}

