using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfDestinationDAL : GenericRepository<Destination>, IDestinationDAL
    {
        public Destination GetDestinationWithGuide(int id)
        {
            using (var c = new Context())
            {
                return c.Destinations.Where(x => x.DestinationID == id).Include(x => x.Guide).FirstOrDefault();
            }
        }

        public List<Destination> GetLast4Destinations()
        {
            using (var context = new Context())
            {
                var values = context.Destinations.Take(4).OrderByDescending(x => x.DestinationID).ToList();
                return values;
            }
        }
    }
}

