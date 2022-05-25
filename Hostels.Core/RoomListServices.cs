using System.Collections.Generic;
using MongoDB.Driver;

namespace Hostels.Core
{
    public class RoomListServices : IRoomListServices
    {
        private readonly IMongoCollection<RoomList> _roomList;
        public RoomListServices(IDbClient dbClient)
        {
            _roomList = dbClient.GetRoomListCollection();
        }
        public List<RoomList> GetRoomList()
        {
            return _roomList.Find(roomList => true).ToList();
        }

        public RoomList GetRoomList(string id) =>_roomList.Find(roomlist => roomlist.Id == id).First();
        

        public RoomList AddRoomList(RoomList roomList)
        {
            _roomList.InsertOne(roomList);
            return roomList;
        }

        public void DeleteRoomList(string id)
        {
            _roomList.DeleteOne(roomList => roomList.Id == id);
        }

        public RoomList UpdateRoomList(RoomList roomList)
        {
            GetRoomList(roomList.Id);
            _roomList.ReplaceOne(b => b.Id == roomList.Id, roomList);
            return roomList;
        }
    }
}