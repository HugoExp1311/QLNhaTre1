using QLnhatre2.DAL;
using QLnhatre2.Models;
using System.Collections.Generic;

namespace QLnhatre2.BLL
{
    public class StudentBLL
    {
        private readonly StudentDAL _studentDAL;

        public StudentBLL()
        {
            _studentDAL = new StudentDAL();
        }

        public List<Student> GetAllStudents()
        {
            return _studentDAL.GetAllStudents();
        }

        public List<Student> GetStudentsByClass(string classCode)
        {
            return _studentDAL.GetStudentsByClass(classCode);
        }
        public bool UpdateStudentStatus(string studentCode, string newStatus)
{
    return _studentDAL.UpdateStudentStatus(studentCode, newStatus);
}
public string GetStudentStatus(string studentCode)
{
    return _studentDAL.GetStudentStatus(studentCode);
}

    }
}
