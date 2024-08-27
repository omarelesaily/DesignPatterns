using StructuralPatterns_Bridge.CompositeClass;
using StructuralPatterns_Bridge.Implementor;

class Program
{
    static void Main(string[] args)
    {
        // Sending an urgent notification via Web
        INotificationSender webSender = new WebNotificationSender();
        INotification urgentWebNotification = new UrgentNotification(webSender);
        urgentWebNotification.Send("Server is down!");
        //OutPut: Urgent Notification: in Red Color
        //OutPut: Sending Web Notification: Server is down!

        // Sending a regular notification via Mobile
        INotificationSender mobileSender = new MobileNotificationSender();
        INotification regularMobileNotification = new RegularNotification(mobileSender);
        regularMobileNotification.Send("You have a new message.");
        //OutPut: Regular Notification: in White Color
        //OutPut: Sending Mobile Notification: You have a new message.        
        
        
        // Sending an urgent notification via Web
        INotification regularWebNotification = new RegularNotification(webSender);
        regularWebNotification.Send("You have got Mail!");
        //OutPut: Urgent Notification: in White Color
        //OutPut: Sending Web Notification: Server is down!

        // Sending a regular notification via Mobile
        INotification urgentMobileNotification = new UrgentNotification(mobileSender);
        urgentMobileNotification.Send("There is an Exception!");
        //OutPut: Regular Notification: in Red Color
        //OutPut: Sending Mobile Notification: You have a new message.

    }
}