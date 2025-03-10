using Confluent.Kafka;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using BvlWeb.Services.Common.Messaging;

namespace BvlWeb.Services.Common.Messaging.Producers
{
    public class KafkaProducer
    {
        private readonly IProducer<Null, string> _producer;
        private readonly MessagingOptions _options;

        public KafkaProducer(IOptions<MessagingOptions> options)
        {
            _options = options.Value;
            var config = new ProducerConfig { BootstrapServers = _options.Kafka.BootstrapServers };
            _producer = new ProducerBuilder<Null, string>(config).Build();
        }

        public async Task ProduceAsync(string message)
        {
            await _producer.ProduceAsync(_options.Kafka.Topic, new Message<Null, string> { Value = message });
        }
    }
}
