using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDAL : GenericRepository<Reservation>, IReservationDAL
    {
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            using(var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Pending" && x.AppUserId == id).ToList();
            }
        }
    }
}

