using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IGuideDAL : IGenericDAL<Guide>
    {
		void ChangeToTrueByGuide(int id);

		void ChangeToFalseByGuide(int id);
	}
}

