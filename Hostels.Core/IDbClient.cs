using MongoDB.Driver;

namespace Hostels.Core
{
    public interface IDbClient
    {
        IMongoCollection<Hostel> GetHostelCollection();
        IMongoCollection<RoomList> GetRoomListCollection();
        IMongoCollection<RoomInfo> GetRoomInfoCollection();

        
    }
}