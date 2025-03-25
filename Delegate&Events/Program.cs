using System;

delegate string NotificationDelegate();
class NotificationService
{
    public static string SendEmail()
    {
        Console.WriteLine("Email Sent.");
        return "Email Notification";
    }

    public static string SendSMS()
    {
        Console.WriteLine("SMS Sent.");
        return "SMS Notification";
    }

    public static string SendPushNotification()
    {
        Console.WriteLine("Push Notification Sent.");
        return "Push Notification";
    }
}
class Program
{ 
    public static void Main(string[] args)
    {
        NotificationDelegate del = NotificationService.SendEmail;
        del += NotificationService.SendSMS;
        del += NotificationService.SendPushNotification;

        // GetInvocationList() to capture all return values, As multi-cast delegate only consider the last return value 
        foreach (NotificationDelegate d in del.GetInvocationList())
        {
            Console.WriteLine($"Notification Log: {d()}");
        }
    }
}
