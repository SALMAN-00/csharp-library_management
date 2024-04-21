using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library
{
    public class Manager<T> where T : BaseEntity
    {
        private IEnumerable<T> _item = [];
        private INotificationService _notificationService;

        public Manager(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        // public Manager(SMSNotificationService smsNotificationService)
        // {
        //     _smsNotificationService = smsNotificationService;
        // }
        public void AddItem(T item)
        {
            if (item.GetType() == typeof(Book))
            {
                var temp = item as Book;
                var findBook = _item.FirstOrDefault(x => x is Book && (x as Book)?.Title == temp.Title);
                if (findBook == null)
                {
                    _notificationService.SendNotificationOnSucess("book titled", temp.Title);
                    _item = _item.Append(item);

                }
                else if (findBook != null)
                {
                    _notificationService.SendNotificationOnFailure("book titled", temp.Title);
                }
            }
            else if (item.GetType() == typeof(User))
            {
                var temp = item as User;
                var findUser = _item.FirstOrDefault(x => x is User && (x as User)?.Name == temp.Name);
                if (findUser == null)
                {
                    _notificationService.SendNotificationOnSucess("User Name", temp.Name);
                    _item = _item.Append(item);

                }
                else if (findUser != null)
                {
                    _notificationService.SendNotificationOnFailure("User Name", temp.Name);

                }

            }
            else throw new Exception($"can't added becuse its not Book or User");
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

        public void DeleteById(Guid id)
        {

            var found = _item.FirstOrDefault(item => item.id == id);
            if (found != null)
            {
                _item = _item.Where(item => item.id != id);
                Console.WriteLine($"has ben Deleted this id : {id}");
            }
            else
            {
                Console.WriteLine($"Not found this id :{id}");

            }
        }

        public T? FindItem(string item)
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
