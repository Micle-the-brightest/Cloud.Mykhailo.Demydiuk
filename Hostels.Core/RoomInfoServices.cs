using System.Collections.Generic;
using MongoDB.Driver;
namespace Hostels.Core
{
    public class RoomInfoServices : IRoomInfoServices
    {
        private readonly IMongoCollection<RoomInfo> _roomInfo;
        public RoomInfoServices(IDbClient dbClient)
        {
            _roomInfo = dbClient.GetRoomInfoCollection();
        }
        public List<RoomInfo> GetRoomInfo()
        {
            return _roomInfo.Find(roomInfo => true).ToList();
        }

        public RoomInfo GetRoomInfo(string id) =>_roomInfo.Find(roomInfo => roomInfo.Id == id).First();
        

        public RoomInfo AddRoomInfo(RoomInfo roomInfo)
        {
            _roomInfo.InsertOne(roomInfo);
            return roomInfo;
        }

        public void DeleteRoomInfo(string id)
        {
            _roomInfo.DeleteOne(roomInfo => roomInfo.Id == id);
        }

        public RoomInfo UpdateRoomInfo(RoomInfo roomInfo)
        {
            GetRoomInfo(roomInfo.Id);
            _roomInfo.ReplaceOne(b => b.Id == roomInfo.Id, roomInfo);
            return roomInfo;
        }
    }
}