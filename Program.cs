using System.Diagnostics;
using Tmds.DBus;

Process.Start("pkill", "-KILL dunst");

Task.Run(async() =>
{
   var notifications = new NotificationService();
   var con = new Connection(Address.Session);
   await con.ConnectAsync();
   await con.RegisterServiceAsync("org.freedesktop.Notifications");
   await con.RegisterObjectAsync(notifications);
   await con.ActivateServiceAsync("org.freedesktop.Notifications");
});
while (true)
   Console.ReadLine();
