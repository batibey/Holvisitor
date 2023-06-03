using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface ICommentDAL : IGenericDAL<Comment>
	{
        public List<Comment> GetListCommentWithDestination();
        public List<Comment> GetListCommentWithDestinationAndUser(int id);
    }
}

