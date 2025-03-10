namespace BvlWeb.Services.Common.Messaging
{
    public class MessagingOptions
    {
        public KafkaOptions Kafka { get; set; }
        public LegacyMqOptions LegacyMq { get; set; }
    }

    public class KafkaOptions
    {
        public string BootstrapServers { get; set; }
        public string Topic { get; set; }
    }

    public class LegacyMqOptions
    {
        public string Host { get; set; }
        public string Queue { get; set; }
    }
}
