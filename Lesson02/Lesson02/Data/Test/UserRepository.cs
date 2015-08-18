using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Lesson02.Data.Test
{
    public class TestUserRepository : IUserRepository
    {
        private readonly List<User> _store;

        public TestUserRepository()
        {
            _store = new List<User>(new[] {
                new User { Id = 1, FirstName = "John", LastName = "Doe"},
                new User { Id = 2, FirstName = "James", LastName = "Doe"}, 
                new User { Id = 3, FirstName = "Jane", LastName = "Doe"}, 
                new User { Id = 4, FirstName = "Jennifer", LastName = "Doe"}
            });
        }

        public IEnumerable<User> All()
        {
            return _store.ToArray();
        }

        public User GetBy(Expression<Func<User, bool>> expression)
        {
            return _store.SingleOrDefault(expression.Compile());
        }

        public int Delete(Expression<Func<User, bool>> expression)
        {
            var predicate = new Predicate<User>(expression.Compile());
            return _store.RemoveAll(predicate);
        }
    }
}
