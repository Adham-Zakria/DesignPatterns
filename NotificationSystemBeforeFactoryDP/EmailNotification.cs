using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemBeforeFactoryDP
{
    public class EmailNotification
    {
        public void Notify(string message) => Console.WriteLine($"Sending Email Notification {message}");
    }
}
