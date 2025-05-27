namespace NotificationSystemAfterFactoryDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Notification Option (Email/SMS) ");
            var options = Console.ReadLine();


            Console.WriteLine("Enter Message ");
            var msg = Console.ReadLine();
      
            var notification= NotificationFactory.CreateNotitfication(options);
            notification.Notify(msg);
        }
    }
}
