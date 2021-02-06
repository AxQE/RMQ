using System;

namespace RMQ.Consumer
{
	class Program
	{
		static void Main(string[] args)
		{
			int consumerId = int.Parse(args[0]);

			var service = new ConsumerService(consumerId);

			Console.WriteLine($"Consumer: {consumerId} launched.");			
		}
	}
}
