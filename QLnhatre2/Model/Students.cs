using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace QLnhatre2.Models
{
    public class Student
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("ma_tre_em")]
        public string StudentCode { get; set; }

        [BsonElement("họ_tên")]
        public string FullName { get; set; }

        [BsonElement("giới_tính")]
        public string Gender { get; set; }

        [BsonElement("ngày_sinh")]
        public DateTime DateOfBirth { get; set; }

        [BsonElement("địa_chỉ")]
        public string Address { get; set; }

        [BsonElement("mã_phụ_huynh")]
        public string ParentCode { get; set; }

        [BsonElement("mã_lớp")]
        public string ClassCode { get; set; }
         [BsonElement("trạng_thái")]
        public string State { get; set; }
        
    }
}
