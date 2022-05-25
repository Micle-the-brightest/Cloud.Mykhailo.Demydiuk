using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Hostels.Core
{
    public class Hostel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public int PostIndex { set; get; }
        public int Count { set; get; }
        public int Person { set; get; }
        public int FreeBedCount { set; get; }
        
    }
}