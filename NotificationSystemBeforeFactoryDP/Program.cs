namespace NotificationSystemBeforeFactoryDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Notification Option (Email/SMS) ");
            var options = Console.ReadLine();


            Console.WriteLine("Enter Message ");
            var msg = Console.ReadLine();

            if (options.ToLower() == "email")
            {
                var notification=new EmailNotification();
                notification.Notify(msg);
            }
            else if(options.ToLower() == "sms")
            {
                var notification = new SmsNotification();
                notification.Notify(msg);
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
        }
    }
}
