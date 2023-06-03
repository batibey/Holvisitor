using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {

        ICommentDAL _commentDAL;

        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public void TAdd(Comment t)
        {
            _commentDAL.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentDAL.Delete(t);
        }

        public Comment TGetById(int id)
        {
            return _commentDAL.GetByID(id);
        }

        public List<Comment> TGetList()
        {
            return _commentDAL.GetList();
        }

        public List<Comment> TGetDestinationByID(int id)
        {
            return _commentDAL.GetListByFilter(x => x.DestinationID == id);
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListCommentWithDestination()
        {
            return _commentDAL.GetListCommentWithDestination();
        }

        /*public List<Comment> TGetListCommentWithDestinationAndUser(int id)
        {
            return _commentDAL.GetListCommentWithDestinationAndUser(id);
        }*/

        public List<Comment> TGetDestinationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

