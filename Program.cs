using System.Reflection;
using Tmds.DBus;

Task.Run(async() =>
{
   var notifications = new MyNotifications();

   var con = new Connection(Address.Session);
   await con.ConnectAsync();
   await con.RegisterServiceAsync("org.freedesktop.Notifications");
   await con.RegisterObjectAsync(notifications);
   await con.ActivateServiceAsync("org.freedesktop.Notifications");
});
while (true)
    Console.ReadLine();
