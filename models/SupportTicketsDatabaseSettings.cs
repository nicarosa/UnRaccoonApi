namespace UnRaccoonApi.Models
{
    public class SupportTicketsDatabaseSettings : ISupportTicketsDatabaseSettings
    {
        public string TicketsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ISupportTicketsDatabaseSettings
    {
        string TicketsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}