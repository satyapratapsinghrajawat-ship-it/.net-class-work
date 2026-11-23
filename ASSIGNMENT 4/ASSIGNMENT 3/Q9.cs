using System;

abstract class Class13
{
    public abstract void SendNotification();
}

class EmailNotification : Class13
{
    public override void SendNotification()
    {
        Console.WriteLine("Email Notification Sent");
    }
}

sealed class Class14 : EmailNotification
{
    public void SpecialNotification()
    {
        Console.WriteLine("Special Email Notification Sent");
    }
}

class Program5454
{
    static void Main()
    {
        EmailNotification obj1 = new EmailNotification();
        obj1.SendNotification();

        Class14 obj2 = new Class14();
        obj2.SendNotification();
        obj2.SpecialNotification();
    }
}