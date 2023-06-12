using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDAL _guideDAL;

        public GuideManager(IGuideDAL guideDAL)
        {
            _guideDAL = guideDAL;
        }

        public void TAdd(Guide t)
        {
            _guideDAL.Insert(t);
        }

        public void TDelete(Guide t)
        {
            _guideDAL.Delete(t);
        }

        public Guide TGetById(int id)
        {
            return _guideDAL.GetByID(id);
        }

        public List<Guide> TGetList()
        {
            return _guideDAL.GetList();
        }

        public void TUpdate(Guide t)
        {
            _guideDAL.Update(t);
        }
    }
}

