using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfGuideDAL : GenericRepository<Guide>, IGuideDAL
    {
        public void ChangeToFalseByGuide(int id)
        {
            Context context = new();
            var values = context.Guides.Find(id);
            values.Status = false;
            context.SaveChanges();
        }

        public void ChangeToTrueByGuide(int id)
        {
            Context context = new();
            var values = context.Guides.Find(id);
            values.Status = true;
            context.SaveChanges();
        }
    }
}

