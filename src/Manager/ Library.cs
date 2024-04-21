using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library
{
    public class Library
    {
        private Manager<User> _userManager;
        private Manager<Book> _bookManager;

        public Library(Manager<User> user, Manager<Book> book)
        {
            _userManager = user;
            _bookManager = book;
        }

        public Manager<Book> BookManager()
        {
            return _bookManager;
        }

        public Manager<User> UserManager()
        {
            return _userManager;
        }
    }
}