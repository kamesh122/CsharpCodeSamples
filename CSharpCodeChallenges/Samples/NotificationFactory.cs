using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeChallenges.Samples
{


    class TestProgram
    {
        static void Main(string[] args)
        {
            INotification emailNotification = NotificationFactory.CreateNotification("Email");
            emailNotification.Notify("Hello via Email!");

            INotification smsNotification = NotificationFactory.CreateNotification("SMS");
            smsNotification.Notify("Hello via SMS!");
        }
    }


    public static class NotificationFactory
    {
        public static INotification CreateNotification(string type)
        {
            return type switch
            {
                "Email" => new EmailNotification(),
                "SMS" => new SmsNotification(),
                "Push" => new PushNotification(),
                _ => throw new ArgumentException("Invalid notification type")
            };
        }
    }
    public interface INotification
    {
        void Notify(string message);
    }
    public class EmailNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class SmsNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }

    public class PushNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Push Notification: {message}");
        }
    }


}
