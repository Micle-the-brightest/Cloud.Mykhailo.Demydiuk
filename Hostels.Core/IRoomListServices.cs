using System.Collections.Generic;

namespace Hostels.Core
{
    public interface IRoomListServices
    {
        List<RoomList> GetRoomList();
        RoomList GetRoomList(string id);
        RoomList AddRoomList(RoomList roomList);
        
        void DeleteRoomList(string id);
        RoomList UpdateRoomList(RoomList roomList);
    }
}