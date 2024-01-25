using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelEventAggregatorPattern
{
    public interface IEventAggregator
    {
        void Subscribe<TEvent>(Action<TEvent> action);
        void Publish<TEvent>(TEvent @event);
    }
}
