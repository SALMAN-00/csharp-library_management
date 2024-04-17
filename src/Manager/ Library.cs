using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library
{
    public class Library
    {
        private IEnumerable<User> _users = [];

        public void AddUser(User user)
        {
            _users = _users.Append(user);
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }

        public IEnumerable<User> SortedByDate()
        {
            var sortUsers = _users.OrderBy(x => x.createdDate);
            return sortUsers;
        }

        public bool DeleteUserById(Guid id)
        {
            var userFound = _users.FirstOrDefault(user => user.id == id);
            if (userFound != null)
            {
                _users = _users.Where(x => x.id != id);
                return true;
            }
            return false;


        }




    }
}