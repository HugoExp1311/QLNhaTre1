using QLnhatre2.BLL;
using QLnhatre2.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace QLnhatre2

{
    public partial class Form1 : Form
    {
     //   private readonly string connectionString = "mongodb://localhost:27017";
      //  private readonly string databaseName = "School"; // Thay bằng tên database của bạn
        private readonly StudentBLL studentBLL;
        public Form1()
        {

            InitializeComponent();
            studentBLL = new StudentBLL();
        }
        private void LoadStudentsByClass(string classCode)
        {
            try
            {
                List<Student> students = studentBLL.GetStudentsByClass(classCode);

                // Xóa dữ liệu cũ trên DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Nếu không có dữ liệu, thông báo và kết thúc
                if (students.Count == 0)
                {
                    MessageBox.Show($"Không tìm thấy học sinh nào trong lớp {classCode}.");
                    return;
                }

                // Tạo cột cho DataGridView nếu chưa có
                dataGridView1.Columns.Add("StudentCode", "Mã Trẻ Em");
                dataGridView1.Columns.Add("FullName", "Họ Tên");
                dataGridView1.Columns.Add("Gender", "Giới Tính");
                dataGridView1.Columns.Add("DateOfBirth", "Ngày Sinh");
                dataGridView1.Columns.Add("Address", "Địa Chỉ");
                dataGridView1.Columns.Add("ParentCode", "Mã Phụ Huynh");
                dataGridView1.Columns.Add("ClassCode", "Mã Lớp");
                dataGridView1.Columns.Add("State", "Trạng Thái");

                // Đổ dữ liệu vào DataGridView
                foreach (var student in students)
                {
                    dataGridView1.Rows.Add(
                        student.StudentCode,
                        student.FullName,
                        student.Gender,
                        student.DateOfBirth.ToShortDateString(),
                        student.Address,
                        student.ParentCode,
                        student.ClassCode,
                        student.State
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadAllStudents()
        {
            try
            {
                List<Student> students = studentBLL.GetAllStudents();

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                if (students.Count == 0)
                {
                    MessageBox.Show("Không có học sinh nào.");
                    return;
                }

                dataGridView1.Columns.Add("StudentCode", "Mã Trẻ Em");
                dataGridView1.Columns.Add("FullName", "Họ Tên");
                dataGridView1.Columns.Add("Gender", "Giới Tính");
                dataGridView1.Columns.Add("DateOfBirth", "Ngày Sinh");
                dataGridView1.Columns.Add("Address", "Địa Chỉ");
                dataGridView1.Columns.Add("ParentCode", "Mã Phụ Huynh");
                dataGridView1.Columns.Add("ClassCode", "Mã Lớp");
                dataGridView1.Columns.Add("State", "Trạng Thái");
                


                foreach (var student in students)
                {
                    dataGridView1.Rows.Add(
                        student.StudentCode,
                        student.FullName,
                        student.Gender,
                        student.DateOfBirth.ToShortDateString(),
                        student.Address,
                        student.ParentCode,
                        student.ClassCode,
                        student.State
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void lớpLA1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadStudentsByClass("L1A");
            buttonĐiểm_danh.Visible = true;
        }

        private void lớpLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadStudentsByClass("L1B");
            buttonĐiểm_danh.Visible = true;
        }




        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllStudents();
        }

        private void bảngTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LoadTableData("Teacher");

        }

        private void danhSachLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void buttonĐiểm_danh_Click(object sender, EventArgs e)
        {
Form2 form2 = new Form2();
    form2.Show();
        }

        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        // Sự kiện khi nhấn nút để load dữ liệu
    }
}
