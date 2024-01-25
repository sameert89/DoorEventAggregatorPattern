using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.ProgramLogger;

namespace DoorModelEventAggregatorPattern
{
    public class AutoClose 
    {
        public Action<AddonInvokeEvent> HandleTimerElapsedEvent { get; set; }
        public AutoClose()
        {
            HandleTimerElapsedEvent = (e) =>
            {
                DoorEventAggregator.Instance.Publish(new DoorStateChangeEvent(Constants.DoorStates.CLOSED));
            };
            DoorEventAggregator.Instance.Subscribe(AddonInvokeEvent);
        }
    }
}
