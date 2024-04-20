using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotificationOnFailure()
        {
            Console.WriteLine("Failure");
        }

        public void SendNotificationOnSucess()
        {
            Console.WriteLine("Sucess");
        }
    }
}