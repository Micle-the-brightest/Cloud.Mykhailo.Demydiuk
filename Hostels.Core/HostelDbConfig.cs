using System.IO;

namespace Hostels.Core
{
    public class HostelDbConfig
    {
        public string Database_Name { get; set; }
        public string Hostel_Collection_Name { get; set; }
        public string RoomList_Collection_Name { get; set; }

        public string RoomInfo_Collection_Name { get; set; }

        public string Connection_String { get; set; }
    }
}