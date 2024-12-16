using QLnhatre2.DAL;
using QLnhatre2.Models;


namespace QLnhatre2.BLL
{
    public class ClassroomBLL
    {
        private readonly ClassroomDAL _classroomDAL;

        public ClassroomBLL()
        {
            _classroomDAL = new ClassroomDAL();
        }

        public List<Classroom> GetAllClassroom()
        {
            return _classroomDAL.GetAllClassroom();
        }


    }
}
