using System;
using Confluent.Kafka;

namespace source
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Kafka!");

            var config = new ProducerConfig
            {
                BootstrapServers = "kafka:9092",
                ClientId = Dns.GetHostName()
            };
        }
    }
}
