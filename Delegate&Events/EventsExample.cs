//using System;

//// Delegate for event
//delegate void NotificationEventHandler(string message);

//// Publisher Class
//class NotificationManager
//{
//    //This is how we declare event.....
//    public event NotificationEventHandler NotificationSent;

//    public void SendNotification(string message)
//    {
//        Console.WriteLine($"Sending Notification: {message}");

//        //using Invoke method we can trigger events.
//        NotificationSent?.Invoke(message);
//    }
//}

//// Subscriber Classes
//class Admin
//{
//    public void OnNotificationReceived(string message)
//    {
//        Console.WriteLine($"Admin received: {message}");
//    }
//}

//class User
//{
//    public void OnNotificationReceived(string message)
//    {
//        Console.WriteLine($"User received: {message}");
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        NotificationManager manager = new NotificationManager();
//        Admin admin = new Admin();
//        User user = new User();

//        // Subscribe to event
//        manager.NotificationSent += admin.OnNotificationReceived;
//        manager.NotificationSent += user.OnNotificationReceived;

//        // Trigger notification
//        manager.SendNotification("System Update Available!");
//    }
//}
