using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library
{
    public class SMSNotificationService : INotificationService
    {
        public void SendNotificationOnFailure(string itemType, string itemName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error adding {itemType} {itemName}. Please email support@library.com.");
            Console.ResetColor();        }

        public void SendNotificationOnSucess(string itemType, string itemName)
        {
          Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{itemType} {itemName} added to Library. Thank you!");
            Console.ResetColor();        }
    }
}