using System;
using System.Collections.Generic;
using System.Text;

namespace RMQ.Consumer
{
	class ConsumerService
	{
		private readonly int _consumerId;

		public ConsumerService(int consumerId)
		{
			_consumerId = consumerId;
		}
	}
}
