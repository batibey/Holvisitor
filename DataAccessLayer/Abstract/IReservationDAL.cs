using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IReservationDAL : IGenericDAL<Reservation>
	{
		List<Reservation> GetListWithReservationByWaitApproval(int id);
		List<Reservation> GetListWithReservationByAccepted(int id);
		List<Reservation> GetListWithReservationByPrevious(int id);
	}
}

