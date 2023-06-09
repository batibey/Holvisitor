﻿using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface ICommentService : IGenericService<Comment>
	{
        List<Comment> TGetDestinationById(int id);
        List<Comment> TGetListCommentWithDestination();
        //public List<Comment> TGetListCommentWithDestinationAndUser(int id);

    }
}

