using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace Hostels.Core
{
    public class HostelServices : IHostelServices
    {
        private readonly IMongoCollection<Hostel> _hostels;
        public HostelServices(IDbClient dbClient)
        {
           _hostels  =  dbClient.GetHostelCollection();
        }
        public List<Hostel> GetHostels()
        {
            return _hostels.Find(hostel => true).ToList();
        }

        public Hostel GetHostel(string id) =>_hostels.Find(hostel => hostel.Id == id).First();
        

        public Hostel AddHostel(Hostel hostel)
        {
            _hostels.InsertOne(hostel);
            return hostel;
        }

        public void DeleteHostel(string id)
        {
            _hostels.DeleteOne(hostel => hostel.Id == id);
        }

        public Hostel UpdateHostel(Hostel hostel)
        {
            GetHostel(hostel.Id);
            _hostels.ReplaceOne(b => b.Id == hostel.Id, hostel);
            return hostel;
        }
    }
}