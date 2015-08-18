using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Lesson02.Data
{
    public interface IUserRepository
    {
        IEnumerable<User> All();
        User GetBy(Expression<Func<User, bool>> expression);
        int Delete(Expression<Func<User, bool>> expression);
    }
}