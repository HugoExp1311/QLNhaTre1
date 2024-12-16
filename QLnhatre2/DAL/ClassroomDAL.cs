using MongoDB.Driver;
using QLnhatre2.Models;
using System;
using System.Collections.Generic;

namespace QLnhatre2.DAL
{
    public class ClassroomDAL
    {
        private readonly IMongoCollection<Classroom> _classroomCollection;

        public ClassroomDAL()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("School");
            _classroomCollection = database.GetCollection<Classroom>("Classroom");
        }

        public List<Classroom> GetAllClassroom()
        {
            return _classroomCollection.Find(student => true).ToList();
        }
public void UpdateActivity(string classCode, string day, List<string> newActivities)
{
    var filter = Builders<Classroom>.Filter.Eq(c => c.ClassCode, classCode);
    var update = Builders<Classroom>.Update.Set($"hoạt_động.{day}", newActivities);
    _classroomCollection.UpdateOne(filter, update);
}
public void UpdateFood(string classCode, string day, List<string> newFoodList)
{
    var filter = Builders<Classroom>.Filter.Eq(c => c.ClassCode, classCode);
    var update = Builders<Classroom>.Update.Set($"thực đơn.{day}", newFoodList);
    _classroomCollection.UpdateOne(filter, update);
}
  public Classroom GetClassroomByCode(string classCode)
{
    var filter = Builders<Classroom>.Filter.Eq(c => c.ClassCode, classCode);
    return _classroomCollection.Find(filter).FirstOrDefault();
}
      


    }
}
