using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotificationOnFailure(string itemType, string itemName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"We encountered an issue adding {itemType} {itemName}. Please review the input data. For more help, visit our FAQ at library.com/faq.");
            Console.ResetColor();
        }

        public void SendNotificationOnSucess(string itemType, string itemName)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Hello, a new {itemType} {itemName} has been successfully added to the Library. If you have any queries or feedback, please contact our support team at support@library.com.");
            Console.ResetColor();
        }
    }
}