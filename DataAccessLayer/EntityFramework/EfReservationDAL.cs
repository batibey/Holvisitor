﻿using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
	public class EfReservationDAL : GenericRepository<Reservation>, IReservationDAL
	{
		
	}
}

