using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace QLnhatre2.Models
{
    public class Classroom
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("mã_lớp_học")]
        public string ClassCode { get; set; }

        [BsonElement("tên_lớp")]
        public string ClassName { get; set; }

        [BsonElement("sĩ_số")]
        public int StudentNumber { get; set; }

        [BsonElement("mã_giáo_viên")]
        public string TeacherCode { get; set; }

        [BsonElement("thực đơn")]
        public Dictionary<string, List<string>> FoodList { get; set; }
        [BsonElement("hoạt_động")]
        public Dictionary<string, List<string>> Activity { get; set; }
        
    }
}
