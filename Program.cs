using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelEventAggregatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buying Door
            SmartDoor myDoorA = new SmartDoor();
            // Subscribing Addons
            var buzzerA = new Buzzer();
            var pagerA = new PagerNotifier();
            var autoCloseA = new AutoClose();
            // Testing
            myDoorA.Open();
        }
    }
}
