using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelEventAggregatorPattern
{
    public class SmartDoor : SimpleDoor
    {
        private Timer timerObj;
        private Action<DoorStateChangeEvent> HandleDoorStateChangeEvent;
        private Action<TimerElapsedEvent> HandleTimerElapsedEvent;
        public SmartDoor(int t = 10)
        {
            timerObj = new Timer(t);
            HandleDoorStateChangeEvent = (e) =>
            {
                Close();
            };
            HandleTimerElapsedEvent = (e) =>
            {
                DoorEventAggregator.Instance.Publish(new AddonInvokeEvent());
            };
            DoorEventAggregator.Instance.Subscribe(HandleDoorStateChangeEvent);
            DoorEventAggregator.Instance.Subscribe(HandleTimerElapsedEvent);
        }
        public override bool Open()
        {
            if (base.Open())
            {
                DoorEventAggregator.Instance.Publish(new DoorStateChangeEvent(Constants.DoorStates.OPEN));
                return true;
            }
            return false;
        }
        public override bool Close()
        {
            if (base.Close())
            {
                DoorEventAggregator.Instance.Publish(new DoorStateChangeEvent(Constants.DoorStates.CLOSED));
                return true;
            }
            return false;
        }
    }
}
