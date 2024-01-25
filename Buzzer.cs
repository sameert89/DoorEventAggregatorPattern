using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.ProgramLogger;

namespace DoorModelEventAggregatorPattern
{
    public class Buzzer 
    {
        public Action<AddonInvokeEvent> HandleTimerElapsedEvent { get; set; }
        public Buzzer()
        {
            HandleTimerElapsedEvent = (e) =>
            {
                Console.Beep();
            };
            DoorEventAggregator.Instance.Subscribe<AddonInvokeEvent>(HandleTimerElapsedEvent);
        }
    }
}
