using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class DestinationManager : IDestinationService
	{
		IDestinationDAL _destinationDAL;

		public DestinationManager(IDestinationDAL destinationDAL)
		{
			_destinationDAL = destinationDAL;
		}

        public void TAdd(Destination t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Destination t)
        {
            throw new NotImplementedException();
        }

        public Destination TGetById(int id)
        {
            return _destinationDAL.GetByID(id);
        }

        public Destination TGetDestinationWithGuide(int id)
        {
            throw new NotImplementedException();
        }

        public List<Destination> TGetLast4Destinations()
        {
            throw new NotImplementedException();
        }

        public List<Destination> TGetList()
        {
            return _destinationDAL.GetList();
        }

        public void TUpdate(Destination t)
        {
            throw new NotImplementedException();
        }
    }
}

