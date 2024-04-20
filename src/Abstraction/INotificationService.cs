using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library
{
    public interface INotificationService
    {
        public void SendNotificationOnSucess(string itemType,string itemName);
        public void SendNotificationOnFailure(string itemType, string itemName);
    }
}