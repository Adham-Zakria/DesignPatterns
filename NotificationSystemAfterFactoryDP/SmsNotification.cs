using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemAfterFactoryDP
{
    public class SmsNotification: INotification
    {
        public void Notify(string message) => Console.WriteLine($"Sending SMS Notification {message}");

    }
}
