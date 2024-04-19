using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library
{
    public class Manager<T> where T : BaseEntity
    {
        private IEnumerable<T> _item = [];

        public void AddOne(T item)
        {
            _item = _item.Append(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _item;
        }

        public IEnumerable<T> SortedByDate()
        {
            var sortItems = _item.OrderBy(x => x.createdDate);
            return sortItems;
        }

        public bool DeleteById(Guid id)
        {
            var found = _item.FirstOrDefault(item => item.id == id);
            if (found != null)
            {
                _item = _item.Where(item => item.id != id);
                return true;
            }
            return false;
        }

        public T? FindOne(string item)
        {
            var book = _item.FirstOrDefault(x => x is Book && (x as Book).Title == item);
            if (book != null)
            {
                return (T)Convert.ChangeType(book, typeof(T));
            }
            var user = _item.FirstOrDefault(x => x is User && (x as User).Name == item);
            if (user != null)
            {
                return (T)Convert.ChangeType(user, typeof(T));
            }
            else throw new Exception("Not Found Title of the Book or Name of the user");
        }
        public IEnumerable<T> Pagination(int PageNumber)
        {
            if (PageNumber > 0 && PageNumber < 3)
            {
                int RecordsPerPage = 5;
                var item = _item.Skip((PageNumber - 1) * RecordsPerPage).Take(RecordsPerPage).ToList();
                return item;
            }
            else
            {
                throw new Exception("page number should be greater than 0 and less than 3");
            }
        }
    }
}
