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
        private readonly ClassroomBLL classroomBLL;
        public Form1()
        {

            InitializeComponent();
            studentBLL = new StudentBLL();
            classroomBLL = new ClassroomBLL();
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

        private void LoadAllClassroom()
        {
            try
            {
                List<Classroom> classrooms = classroomBLL.GetAllClassroom();

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                if (classrooms.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu.");
                    return;
                }

                dataGridView1.Columns.Add("ClassCode", "Mã lớp học");
                dataGridView1.Columns.Add("ClassName", "Tên lớp");
                dataGridView1.Columns.Add("StudentNumber", "Sĩ số");
                dataGridView1.Columns.Add("TeacherCode", "Mã số giáo viên");
                dataGridView1.Columns.Add("Day", "Ngày");
                dataGridView1.Columns.Add("FoodList", "Thực đơn");
                dataGridView1.Columns.Add("Activity", "Hoạt động");

                foreach (var classroom in classrooms)
                {
                    if (classroom.FoodList != null && classroom.Activity != null)
                    {
                        foreach (var day in classroom.FoodList)
                        {
                            var activities = classroom.Activity.ContainsKey(day.Key) ? classroom.Activity[day.Key] : new List<string>();

                            // Kết hợp danh sách món ăn và hoạt động thành chuỗi
                            string foodListString = string.Join(", ", day.Value);
                            string activityString = string.Join(", ", activities);

                            dataGridView1.Rows.Add(
                                classroom.ClassCode,
                                classroom.ClassName,
                                classroom.StudentNumber,
                                classroom.TeacherCode,
                                day.Key, // Ngày
                                foodListString, // Thực đơn
                                activityString // Hoạt động
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        
        private void LoadClassroomByCode(string classCode)
{
    try
    {
        // Gọi đến tầng BLL để lấy thông tin lớp học theo mã lớp
        Classroom classroom = classroomBLL.GetClassroomByCode(classCode);

        dataGridView1.DataSource = null;
        dataGridView1.Rows.Clear();
        dataGridView1.Columns.Clear();

        if (classroom == null)
        {
            MessageBox.Show($"Không tìm thấy lớp học với mã {classCode}");
            return;
        }

        dataGridView1.Columns.Add("ClassCode", "Mã lớp học");
        dataGridView1.Columns.Add("ClassName", "Tên lớp");
        dataGridView1.Columns.Add("StudentNumber", "Sĩ số");
        dataGridView1.Columns.Add("TeacherCode", "Mã số giáo viên");
        dataGridView1.Columns.Add("Day", "Ngày");
        dataGridView1.Columns.Add("FoodList", "Thực đơn");
        dataGridView1.Columns.Add("Activity", "Hoạt động");

        if (classroom.FoodList != null && classroom.Activity != null)
        {
            foreach (var day in classroom.FoodList)
            {
                var activities = classroom.Activity.ContainsKey(day.Key) ? classroom.Activity[day.Key] : new List<string>();

                // Kết hợp danh sách món ăn và hoạt động thành chuỗi
                string foodListString = string.Join(", ", day.Value);
                string activityString = string.Join(", ", activities);

                dataGridView1.Rows.Add(
                    classroom.ClassCode,
                    classroom.ClassName,
                    classroom.StudentNumber,
                    classroom.TeacherCode,
                    day.Key, // Ngày
                    foodListString, // Thực đơn
                    activityString // Hoạt động
                );
            }
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

        private void lớpL1AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoạt_động.Visible = true;
            thucdon.Visible = true;
           // LoadAllClassroom();
            LoadClassroomByCode("L1A");
        }

        private void Hoạt_động_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void lớpL1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Hoạt_động.Visible = true;
            thucdon.Visible = true;
           // LoadAllClassroom();
            LoadClassroomByCode("L1B");
        }

        private void thucdon_Click(object sender, EventArgs e)
        {
ThucDon thucDon = new  ThucDon();
            thucDon.Show();
        }


        // Sự kiện khi nhấn nút để load dữ liệu
    }
}
