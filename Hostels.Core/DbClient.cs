using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Hostels.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Hostel> _hostels;
        private readonly IMongoCollection<RoomList> _roomList;
        private readonly IMongoCollection<RoomInfo> _roomInfo;

        public DbClient(IOptions<HostelDbConfig> hostelDbConfig)
        {
            var client = new MongoClient(hostelDbConfig.Value.Connection_String);
            var database = client.GetDatabase(hostelDbConfig.Value.Database_Name);
            _hostels = database.GetCollection<Hostel>(hostelDbConfig.Value.Hostel_Collection_Name);
            _roomList = database.GetCollection<RoomList>(hostelDbConfig.Value.RoomList_Collection_Name);

            _roomInfo = database.GetCollection<RoomInfo>(hostelDbConfig.Value.RoomInfo_Collection_Name);

        }

        public IMongoCollection<Hostel> GetHostelCollection() => _hostels;
        
           

        public IMongoCollection<RoomList> GetRoomListCollection() => _roomList;


        public IMongoCollection<RoomInfo> GetRoomInfoCollection() => _roomInfo;

    }
}