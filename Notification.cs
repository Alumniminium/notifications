using System.Collections.Generic;
public class Notification
{
    private string appname;
    private uint replacesid;
    private string appicon;
    private string summary;
    private string body;
    private string[] actions;
    private IDictionary<string, object> hints;
    private int expireTimeout;
    public Notification(string AppName, uint ReplacesId, string AppIcon, string Summary, string Body, string[] Actions, IDictionary<string, object> Hints, int ExpireTimeout)
    {
        appname = AppName;
        replacesid = ReplacesId;
        appicon = AppIcon;
        summary = Summary;
        body = Body;
        actions = Actions;
        hints = Hints;
        expireTimeout = ExpireTimeout;
    }
    public void DisplayNotification()
    {
        Console.WriteLine($"App: {appname}\nSummary: {summary}\nBody: {body}");
    }
}