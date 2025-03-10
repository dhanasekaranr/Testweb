using System.Threading.Tasks;
using BvlWeb.Services.Common.Messaging;

namespace BvlWeb.Services.Common.Messaging.Producers
{
    public class LegacyMqProducer
    {
        private readonly MessagingOptions _options;

        public LegacyMqProducer(MessagingOptions options)
        {
            _options = options;
        }

        public Task ProduceAsync(string message)
        {
            // Dummy implementation: In production, send the message to the legacy MQ.
            return Task.CompletedTask;
        }
    }
}
