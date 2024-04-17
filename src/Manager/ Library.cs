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

        public User? FindUserByName(string name)
        {
            var userName = _users.FirstOrDefault(x => x.Name == name);
            if (userName != null)
            {
                return userName;
            }
            else
            {
                return null;
            }
        }
        public IEnumerable<User> UserPagination(int PageNumber)
        {
            if (PageNumber > 0 && PageNumber < 3)
            {
                int RecordsPerPage = 5;
                var user = _users.Skip((PageNumber - 1) * RecordsPerPage).Take(RecordsPerPage).ToList();
                return user;
            }
            else
            {
                throw new Exception("page number should be greater than 0 and less than 3");
            }
        }
    }
}