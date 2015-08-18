using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Lesson02.Data;
using Lesson02.Data.SqlServer;
using System.IO;

namespace Lesson02
{
    public class HandyDandyApplication
    {
        private IUserRepository _users;

        public HandyDandyApplication(IUserRepository repository = null)
        {
            _users = repository ?? new UserRepository();
        }

        public void DisplayUsers(TextWriter writer)
        {
            foreach (var user in _users.All())
            {
                var userData = string.Format("{0}\t{1} {2}",
                    user.Id,
                    user.FirstName, 
                    user.LastName);

                writer.WriteLineAsync(userData);
            }
        }
    }
}
