using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IReservationService : IGenericService<Reservation>
	{

		List<Reservation> GetListWithReservationByWaitApproval(int id);

    }
}

