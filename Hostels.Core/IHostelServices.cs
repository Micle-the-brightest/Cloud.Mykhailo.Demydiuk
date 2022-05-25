using System.Collections.Generic;

namespace Hostels.Core
{
    public interface IHostelServices 
    {
        List<Hostel> GetHostels();
        Hostel GetHostel(string id);
        Hostel AddHostel(Hostel hostel);

        void DeleteHostel(string id);
        Hostel UpdateHostel(Hostel hostel);
    }
}