using System.Collections;

namespace UZUSIS.Application;

public class Notification : INotification
{
    public bool notFound { get; set; } = false; 
    private List<string> _notifications { get; set; } = new();
    
    
    public void AddNotification(string message)
    {
        _notifications.Add(message);    
    }

    public void AddNotification(List<string> messages)
    {
        _notifications.AddRange(messages);
    }

    public bool hasNotification() => _notifications.Any();

    public void NotFound()
    {
        notFound = true;
    }

    public List<string> GetNotifications()
    {
        return _notifications;
    }
}