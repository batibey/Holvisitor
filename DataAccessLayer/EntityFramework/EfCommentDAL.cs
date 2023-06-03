using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentDAL : GenericRepository<Comment>, ICommentDAL
    {
        public List<Comment> GetListCommentWithDestination()
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}

