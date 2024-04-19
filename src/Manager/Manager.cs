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

        public bool DeleteOne(Guid id)
        {
            var found = _item.FirstOrDefault(item => item.id == id);
            if (found != null)
            {
                _item = _item.Where(item => item.id != id);
                return true;
            }
            return false;
        }

        public T? FindOne(T item)
        {
            var findItem = _item.FirstOrDefault(x => x.id == item.id);
            if (findItem != null)
            {
                return findItem;
            }
            else
            {
                return null;
            }
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
