using MongoDB.Driver;
using QLnhatre2.Models;
using System;
using System.Collections.Generic;

namespace QLnhatre2.DAL
{
    public class StudentDAL
    {
        private readonly IMongoCollection<Student> _studentCollection;

        public StudentDAL()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("School");
            _studentCollection = database.GetCollection<Student>("Students");
        }

        public List<Student> GetAllStudents()
        {
            return _studentCollection.Find(student => true).ToList();
        }

        public List<Student> GetStudentsByClass(string classCode)
        {
            var filter = Builders<Student>.Filter.Eq("mã_lớp", classCode);
            return _studentCollection.Find(filter).ToList();
        }
        public bool UpdateStudentStatus(string studentCode, string newStatus)
{
    var filter = Builders<Student>.Filter.Eq(s => s.StudentCode, studentCode);
    var update = Builders<Student>.Update.Set(s => s.State, newStatus);

    var result = _studentCollection.UpdateOne(filter, update);

    return result.ModifiedCount > 0;
}
public string GetStudentStatus(string studentCode)
{
    var filter = Builders<Student>.Filter.Eq(s => s.StudentCode, studentCode);
    var student = _studentCollection.Find(filter).FirstOrDefault();

    return student?.State;
}


    }
}
