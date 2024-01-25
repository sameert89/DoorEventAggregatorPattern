using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.ProgramLogger;

namespace DoorModelEventAggregatorPattern
{
    public class PagerNotifier 
    {
        public Action<AddonInvokeEvent> HandleTimerElapsedEvent { get; set; }
        public PagerNotifier()
        {
            HandleTimerElapsedEvent = (e) =>
            {
                // Pager Logic
            };
            DoorEventAggregator.Instance.Subscribe<AddonInvokeEvent>(HandleTimerElapsedEvent);
        }
    }
}
