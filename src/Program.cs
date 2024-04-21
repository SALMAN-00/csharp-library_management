using library;

internal class Program
{
    private static void Main()
    {
        INotificationService emailService = new EmailNotificationService();
        Manager<Book> BookFactory1 = new Manager<Book>(emailService);
        Manager<User> UserFactory1 = new Manager<User>(emailService);

        Library library1 = new Library(UserFactory1, BookFactory1);
        var UserManager1 = library1.UesrManager();
        var BookManager1 = library1.BookManager();


        INotificationService smsService = new SMSNotificationService();
        Manager<Book> BookFactory2 = new Manager<Book>(smsService);
        Manager<User> UserFactory2 = new Manager<User>(smsService);

        Library library2 = new Library(UserFactory2, BookFactory2);
        var UserManager2 = library2.UesrManager();
        var BookManager2 = library2.BookManager();




        User user1 = new User("Alice", new DateTime(2023, 1, 1));
        User user2 = new User("Bob", new DateTime(2023, 2, 1));
        User user3 = new User("Charlie", new DateTime(2023, 3, 1));
        User user4 = new User("David", new DateTime(2023, 4, 1));
        User user5 = new User("Eve", new DateTime(2024, 5, 1));
        User user6 = new User("Fiona", new DateTime(2024, 6, 1));
        User user7 = new User("George", new DateTime(2024, 7, 1));
        User user8 = new User("Hannah", new DateTime(2024, 8, 1));
        User user9 = new User("Ian");
        User user10 = new User("Julia");

        Book book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        Book book2 = new Book("1984", new DateTime(2023, 2, 1));
        Book book3 = new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1));
        Book book4 = new Book("The Catcher in the Rye", new DateTime(2023, 4, 1));
        Book book5 = new Book("Pride and Prejudice", new DateTime(2023, 5, 1));
        Book book6 = new Book("Wuthering Heights", new DateTime(2023, 6, 1));
        Book book7 = new Book("Jane Eyre", new DateTime(2023, 7, 1));
        Book book8 = new Book("Brave New World", new DateTime(2023, 8, 1));
        Book book9 = new Book("Moby-Dick", new DateTime(2023, 9, 1));
        Book book10 = new Book("War and Peace", new DateTime(2023, 10, 1));
        Book book11 = new Book("Hamlet", new DateTime(2023, 11, 1));
        Book book12 = new Book("Great Expectations", new DateTime(2023, 12, 1));
        Book book13 = new Book("Ulysses", new DateTime(2024, 1, 1));
        Book book14 = new Book("The Odyssey", new DateTime(2024, 2, 1));
        Book book15 = new Book("The Divine Comedy", new DateTime(2024, 3, 1));
        Book book16 = new Book("Crime and Punishment", new DateTime(2024, 4, 1));
        Book book17 = new Book("The Brothers Karamazov", new DateTime(2024, 5, 1));
        Book book18 = new Book("Don Quixote", new DateTime(2024, 6, 1));
        Book book19 = new Book("The Iliad");
        Book book20 = new Book("Anna Karenina");


        UserManager1.AddItem(user1);
        UserManager1.AddItem(user2);
        UserManager1.AddItem(user3);
        UserManager1.AddItem(user4);
        UserManager1.AddItem(user5);
        UserManager1.AddItem(user5);
        UserManager1.AddItem(user6);
        UserManager1.AddItem(user7);
        UserManager1.AddItem(user8);
        UserManager1.AddItem(user9);
        UserManager1.AddItem(user10);
        UserManager1.AddItem(user10);

        BookManager1.AddItem(book1);
        BookManager1.AddItem(book2);
        BookManager1.AddItem(book3);
        BookManager1.AddItem(book4);
        BookManager1.AddItem(book5);
        BookManager1.AddItem(book6);
        BookManager1.AddItem(book7);
        BookManager1.AddItem(book8);
        BookManager1.AddItem(book9);
        BookManager1.AddItem(book10);
        BookManager1.AddItem(book11);
        BookManager1.AddItem(book12);
        BookManager1.AddItem(book13);
        BookManager1.AddItem(book14);
        BookManager1.AddItem(book15);
        BookManager1.AddItem(book16);
        BookManager1.AddItem(book17);
        BookManager1.AddItem(book18);
        BookManager1.AddItem(book19);
        BookManager1.AddItem(book20);
        BookManager1.AddItem(book20);



        UserManager2.AddItem(user1);
        UserManager2.AddItem(user2);
        UserManager2.AddItem(user3);
        UserManager2.AddItem(user4);
        UserManager2.AddItem(user5);
        UserManager2.AddItem(user6);
        UserManager2.AddItem(user7);
        UserManager2.AddItem(user8);
        UserManager2.AddItem(user9);
        UserManager2.AddItem(user10);
        UserManager2.AddItem(user10);

        BookManager2.AddItem(book1);
        BookManager2.AddItem(book2);
        BookManager2.AddItem(book3);
        BookManager2.AddItem(book4);
        BookManager2.AddItem(book5);
        BookManager2.AddItem(book6);
        BookManager2.AddItem(book7);
        BookManager2.AddItem(book8);
        BookManager2.AddItem(book9);
        BookManager2.AddItem(book10);
        BookManager2.AddItem(book11);
        BookManager2.AddItem(book12);
        BookManager2.AddItem(book13);
        BookManager2.AddItem(book14);
        BookManager2.AddItem(book15);
        BookManager2.AddItem(book16);
        BookManager2.AddItem(book17);
        BookManager2.AddItem(book18);
        BookManager2.AddItem(book19);
        BookManager2.AddItem(book20);
        BookManager2.AddItem(book20);


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n_______________________________________ Library1 Detailas _______________________________________\n");
        Console.ResetColor();
        Console.WriteLine("\n_______________________________________ All Users _______________________________________\n");

        var getAllUsers = UserManager1.GetAll();
        foreach (var user in getAllUsers)
        {
            Console.WriteLine($"User Name: {user.Name} | Created Date: {user.createdDate} | User Id: {user.id}\n");

        }
        Console.WriteLine("\n_______________________________________ Sort All Users By Create Date _______________________________________\n");

        var sortUserByDate = UserManager1.SortedByDate();
        foreach (var sortUsers in sortUserByDate)
        {
            Console.WriteLine($"User Name: {sortUsers.Name} | Created Date: {sortUsers.createdDate} | User Id: {sortUsers.id}\n");
        }
        Console.WriteLine("\n_______________________________________ After Delete User _______________________________________\n");
        UserManager1.DeleteById(user1.id);
        var afterDelete = UserManager1.GetAll();
        foreach (var user in afterDelete)
        {
            Console.WriteLine($"User Name: {user.Name} | Created Date: {user.createdDate} | User Id: {user.id}\n");
        }
        Console.WriteLine("\n_______________________________________ Find User By Name _______________________________________\n");
        var userFindByName = UserManager1.FindItem("Bob");
        Console.WriteLine($"User Name: {userFindByName.Name} | Created Date: {userFindByName.createdDate} | User Id: {userFindByName.id}\n");

        Console.WriteLine("\n_______________________________________ User pagination _______________________________________\n");
        var pagination = UserManager1.Pagination(1);
        foreach (var page in pagination)
        {
            Console.WriteLine($"User Name: {page.Name} | Created Date: {page.createdDate} | User Id: {page.id}\n");

        }

        Console.WriteLine("\n_______________________________________ All Books _______________________________________\n");
        var allBooks = BookManager1.GetAll();
        foreach (var book in allBooks)
        {
            Console.WriteLine($"Book Title: {book.Title} | Created Date: {book.createdDate} | Book Id: {book.id}\n");

        }
        Console.WriteLine("\n_______________________________________ Sort All Books By Create Date _______________________________________\n");
        var sort = BookManager1.SortedByDate();
        foreach (var book in sort)
        {
            Console.WriteLine($"Book Title: {book.Title} | Created Date: {book.createdDate} | Book Id: {book.id}\n");

        }
        Console.WriteLine("\n_______________________________________ After Delete Book _______________________________________\n");
        BookManager1.DeleteById(book1.id);
        var afterDeleteBook = BookManager1.GetAll();
        foreach (var book in afterDeleteBook)
        {
            Console.WriteLine($"Book Title: {book.Title} | Created Date: {book.createdDate} | Book Id: {book.id}\n");

        }
        Console.WriteLine("\n_______________________________________ Find Book By Title _______________________________________\n");
        var findBook = BookManager1.FindItem("1984");
        Console.WriteLine($"Book Title: {findBook.Title} | Created Date: {findBook.createdDate} | Book Id: {findBook.id}\n");

        Console.WriteLine("\n_______________________________________ Book pagination _______________________________________\n");
        var bookPagination = BookManager1.Pagination(1);
        foreach (var page in bookPagination)
        {
            Console.WriteLine($"Book Title: {page.Title} | Created Date: {page.createdDate} | Book Id: {page.id}\n");

        }





















        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n_______________________________________ Library2 Detailas _______________________________________\n");
        Console.ResetColor();
        Console.WriteLine("\n_______________________________________ All Users _______________________________________\n");

        var getAllUsers2 = UserManager2.GetAll();
        foreach (var user in getAllUsers2)
        {
            Console.WriteLine($"User Name: {user.Name} | Created Date: {user.createdDate} | User Id: {user.id}\n");

        }
        Console.WriteLine("\n_______________________________________ Sort All Users By Create Date _______________________________________\n");

        var sortUserByDate2 = UserManager2.SortedByDate();
        foreach (var sortUsers in sortUserByDate2)
        {
            Console.WriteLine($"User Name: {sortUsers.Name} | Created Date: {sortUsers.createdDate} | User Id: {sortUsers.id}\n");
        }
        Console.WriteLine("\n_______________________________________ After Delete User _______________________________________\n");
        UserManager2.DeleteById(user1.id);
        var afterDelete2 = UserManager2.GetAll();
        foreach (var user in afterDelete2)
        {
            Console.WriteLine($"User Name: {user.Name} | Created Date: {user.createdDate} | User Id: {user.id}\n");
        }
        Console.WriteLine("\n_______________________________________ Find User By Name _______________________________________\n");
        var userFindByName2 = UserManager2.FindItem("Bob");
        Console.WriteLine($"User Name: {userFindByName2.Name} | Created Date: {userFindByName2.createdDate} | User Id: {userFindByName2.id}\n");

        Console.WriteLine("\n_______________________________________ User pagination _______________________________________\n");
        var pagination2 = UserManager2.Pagination(1);
        foreach (var page in pagination2)
        {
            Console.WriteLine($"User Name: {page.Name} | Created Date: {page.createdDate} | User Id: {page.id}\n");

        }

        Console.WriteLine("\n_______________________________________ All Books _______________________________________\n");
        var allBooks2 = BookManager2.GetAll();
        foreach (var book in allBooks2)
        {
            Console.WriteLine($"Book Title: {book.Title} | Created Date: {book.createdDate} | Book Id: {book.id}\n");

        }
        Console.WriteLine("\n_______________________________________ Sort All Books By Create Date _______________________________________\n");
        var sort2 = BookManager2.SortedByDate();
        foreach (var book in sort)
        {
            Console.WriteLine($"Book Title: {book.Title} | Created Date: {book.createdDate} | Book Id: {book.id}\n");

        }
        Console.WriteLine("\n_______________________________________ After Delete Book _______________________________________\n");
        BookManager2.DeleteById(book1.id);
        var afterDeleteBook2 = BookManager2.GetAll();
        foreach (var book in afterDeleteBook2)
        {
            Console.WriteLine($"Book Title: {book.Title} | Created Date: {book.createdDate} | Book Id: {book.id}\n");

        }
        Console.WriteLine("\n_______________________________________ Find Book By Title _______________________________________\n");
        var findBook2 = BookManager2.FindItem("1984");
        Console.WriteLine($"Book Title: {findBook2.Title} | Created Date: {findBook2.createdDate} | Book Id: {findBook2.id}\n");

        Console.WriteLine("\n_______________________________________ Book pagination _______________________________________\n");
        var bookPagination2 = BookManager2.Pagination(1);
        foreach (var page in bookPagination2)
        {
            Console.WriteLine($"Book Title: {page.Title} | Created Date: {page.createdDate} | Book Id: {page.id}\n");

        }
    }

}

