using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemAfterFactoryDP
{
    internal class NotificationFactory
    {
        public static INotification CreateNotitfication(string option) 
        {
            if (option.ToLower() == "email")
            {
                return new EmailNotification();
            }
            else if (option.ToLower() == "sms")
            {
                return new SmsNotification();

            }
            else throw new ArgumentException();
        }
    }
}
