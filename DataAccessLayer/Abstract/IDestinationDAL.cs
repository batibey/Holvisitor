using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IDestinationDAL : IGenericDAL<Destination>
    {
        public Destination GetDestinationWithGuide(int id);
        public List<Destination> GetLast4Destinations();
    }
}

