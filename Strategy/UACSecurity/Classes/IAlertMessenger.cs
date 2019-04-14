namespace UACSecurity.Classes
{
    public interface IAlertMessenger
    {
        string AlertStatus { get; set; }
        string SendAlert();
    }
}