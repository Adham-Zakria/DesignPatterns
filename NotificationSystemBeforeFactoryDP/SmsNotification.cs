﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemBeforeFactoryDP
{
    public class SmsNotification
    {
        public void Notify(string message) => Console.WriteLine($"Sending SMS Notification {message}");

    }
}
