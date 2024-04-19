using library;

internal class Program
{
    private static void Main()
    {

        Manager<Book> BookFactory = new Manager<Book>();
        Manager<User> UserFactory = new Manager<User>();
        
        Library library1 = new Library(UserFactory, BookFactory);
        var UserManager = library1.UesrManager();
        var BookManager = library1.BookManager();


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


        UserManager.AddOne(user1);
        UserManager.AddOne(user2);
        UserManager.AddOne(user3);
        UserManager.AddOne(user4);
        UserManager.AddOne(user5);
        UserManager.AddOne(user6);
        UserManager.AddOne(user7);
        UserManager.AddOne(user8);
        UserManager.AddOne(user9);
        UserManager.AddOne(user10);


        BookManager.AddOne(book1);
        BookManager.AddOne(book2);
        BookManager.AddOne(book3);
        BookManager.AddOne(book4);
        BookManager.AddOne(book5);
        BookManager.AddOne(book6);
        BookManager.AddOne(book7);
        BookManager.AddOne(book8);
        BookManager.AddOne(book9);
        BookManager.AddOne(book10);
        BookManager.AddOne(book11);
        BookManager.AddOne(book12);
        BookManager.AddOne(book13);
        BookManager.AddOne(book14);
        BookManager.AddOne(book15);
        BookManager.AddOne(book16);
        BookManager.AddOne(book17);
        BookManager.AddOne(book18);
        BookManager.AddOne(book19);
        BookManager.AddOne(book20);

        Console.WriteLine("\n_______________________________________ All Users _______________________________________\n");

        var getAllUsers = UserManager.GetAll();
        foreach (var user in getAllUsers)
        {
            Console.WriteLine($"User Name: {user.Name} | Created Date: {user.createdDate} | User Id: {user.id}\n");

        }
        Console.WriteLine("\n_______________________________________ Sort All Users By Create Date _______________________________________\n");

        var sortUserByDate = UserManager.SortedByDate();
        foreach (var sortUsers in sortUserByDate)
        {
            Console.WriteLine($"User Name: {sortUsers.Name} | Created Date: {sortUsers.createdDate} | User Id: {sortUsers.id}\n");
        }
        Console.WriteLine("\n_______________________________________ After Delete User _______________________________________\n");
        var deleteUser = UserManager.DeleteById(user1.id);
        if (deleteUser) { Console.WriteLine("Delete successfully"); }
        var afterDelete = UserManager.GetAll();
        foreach (var user in afterDelete)
        {
            Console.WriteLine($"User Name: {user.Name} | Created Date: {user.createdDate} | User Id: {user.id}\n");
        }
        Console.WriteLine("\n_______________________________________ Find User By Name _______________________________________\n");
        var userFindByName = UserManager.FindOne("Bob");
        Console.WriteLine($"User Name: {userFindByName.Name} | Created Date: {userFindByName.createdDate} | User Id: {userFindByName.id}\n");

        Console.WriteLine("\n_______________________________________ User pagination _______________________________________\n");
        var pagination = UserManager.Pagination(1);
        foreach (var page in pagination)
        {
            Console.WriteLine($"User Name: {page.Name} | Created Date: {page.createdDate} | User Id: {page.id}\n");

        }

        Console.WriteLine("\n_______________________________________ All Books _______________________________________\n");
        var allBooks = BookManager.GetAll();
        foreach (var book in allBooks)
        {
            Console.WriteLine($"Book Title: {book.Title} | Created Date: {book.createdDate} | Book Id: {book.id}\n");

        }
        Console.WriteLine("\n_______________________________________ Sort All Books By Create Date _______________________________________\n");
        var sort = BookManager.SortedByDate();
        foreach (var book in sort)
        {
            Console.WriteLine($"Book Title: {book.Title} | Created Date: {book.createdDate} | Book Id: {book.id}\n");

        }
        Console.WriteLine("\n_______________________________________ After Delete Book _______________________________________\n");
        var delete = BookManager.DeleteById(book1.id);
        if (delete) { Console.WriteLine("Delete successfully"); }
        var afterDeleteBook = BookManager.GetAll();
        foreach (var book in afterDeleteBook)
        {
            Console.WriteLine($"Book Title: {book.Title} | Created Date: {book.createdDate} | Book Id: {book.id}\n");

        }
        Console.WriteLine("\n_______________________________________ Find Book By Title _______________________________________\n");
        var findBook = BookManager.FindOne("1984");
        Console.WriteLine($"Book Title: {findBook.Title} | Created Date: {findBook.createdDate} | Book Id: {findBook.id}\n");

        Console.WriteLine("\n_______________________________________ Book pagination _______________________________________\n");
        var bookPagination = BookManager.Pagination(1);
        foreach (var page in bookPagination)
        {
            Console.WriteLine($"Book Title: {page.Title} | Created Date: {page.createdDate} | Book Id: {page.id}\n");

        }
    }

}

