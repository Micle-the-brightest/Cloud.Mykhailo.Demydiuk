using System.Collections.Generic;

namespace Hostels.Core
{
    public interface IRoomInfoServices
    {
        List<RoomInfo> GetRoomInfo();
        RoomInfo GetRoomInfo(string id);
        RoomInfo AddRoomInfo(RoomInfo roomInfo);
        void DeleteRoomInfo(string id);
        RoomInfo UpdateRoomInfo(RoomInfo roomInfo);
    }
}