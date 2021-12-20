using Notifications.DBus;
using Tmds.DBus;

public class MyNotifications : INotifications
{
    public ObjectPath ObjectPath { get; } = "/org/freedesktop/Notifications";
    public Task<string[]> GetCapabilitiesAsync()
    {
        return Task.FromResult(new[]
        {
             "action-icons", "actions", "body",
             "body-hyperlinks","body-images",
             "body-markup", "icon-multi", "icon-static",
             "persistence", "sound"
        });
    }
    public Task<uint> NotifyAsync(string AppName, uint ReplacesId, string AppIcon, string Summary, string Body, string[] Actions, IDictionary<string, object> Hints, int ExpireTimeout)
    {
        Console.WriteLine(AppName);
        Console.WriteLine(Summary);
        Console.WriteLine(Body);
        return Task.FromResult<uint>(1);
    }
    public Task CloseNotificationAsync(uint Id)
    {
        return Task.CompletedTask;
    }
    public Task<(string name, string vendor, string version, string specVersion)> GetServerInformationAsync()
    {
        return Task.FromResult(("Trbl Notification Server", "her.s", "0.01", "1"));
    }
    // public Task<IDisposable> WatchNotificationClosedAsync(Action<(uint id, uint reason)> handler, Action<Exception> onError = null) => Task.FromResult<IDisposable>(default);
    // public Task<IDisposable> WatchActionInvokedAsync(Action<(uint id, string actionKey)> handler, Action<Exception> onError = null) => Task.FromResult<IDisposable>(null);
}