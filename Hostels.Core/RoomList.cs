using System.Collections.Generic;
using System.IO;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Hostels.Core
{
    public class RoomList
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { set; get; }
        public int NumRoom { set; get; }
        public int RoomCount { set; get; }
        public int PersonCount { set; get; }
        public int FreeBedCount { set; get; }
        public double RoomArea { set; get; }
        public string RoomSex { set; get; }
        
        
    }
}