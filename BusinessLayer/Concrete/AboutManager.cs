using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void TAdd(About t)
        {
            _aboutDAL.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDAL.Delete(t);
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            return _aboutDAL.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutDAL.Update(t);
        }
    }
}

