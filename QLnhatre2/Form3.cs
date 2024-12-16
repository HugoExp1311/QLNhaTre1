using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLnhatre2.DAL;

namespace QLnhatre2
{
    public partial class Form3 : Form
    {
        private ClassroomDAL classroomDAL;
        public Form3()
        {

            InitializeComponent();
            classroomDAL = new ClassroomDAL();
        }
        

        private void btnUpdateActivity_Click_1(object sender, EventArgs e)
        {
string classCode = txtClassCode.Text.Trim();
            string day = txtDay.Text.Trim();
            string activitiesInput = txtActivity.Text.Trim();

            if (string.IsNullOrEmpty(classCode) || string.IsNullOrEmpty(day) || string.IsNullOrEmpty(activitiesInput))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Chuyển chuỗi hoạt động thành List<string>, ngăn cách bởi dấu phẩy
            List<string> newActivities = activitiesInput.Split(',').Select(a => a.Trim()).ToList();

            try
            {
                classroomDAL.UpdateActivity(classCode, day, newActivities);
                MessageBox.Show("Cập nhật hoạt động thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }
    
    }
}
