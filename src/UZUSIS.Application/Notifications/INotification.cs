namespace UZUSIS.Application;

public interface INotification
{
    public bool notFound { get; set; }
    void AddNotification(string message);
    void AddNotification(List<string> messages);
    bool hasNotification();
    void NotFound();
    List<string> GetNotifications();
}