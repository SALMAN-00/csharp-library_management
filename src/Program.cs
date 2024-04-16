using library;

internal class Program
{
    private static void Main()
    {

        Book book1 = new Book("Learn C#", new DateTime(2020, 1, 5));
        Console.WriteLine("\n_______________________________________ Book Dtailes _______________________________________\n");
        Console.WriteLine($"Book Name: {book1.Title} Created Date: {book1.createdDate} Book Id: {book1.id}");

        User user1 = new User("salman", new DateTime(2024, 4, 16));
        Console.WriteLine("\n_______________________________________ User Dtailes _______________________________________\n");
        Console.WriteLine($"User Name: {user1.Name} Created Date: {user1.createdDate} User Id: {user1.id}\n");


    }


}