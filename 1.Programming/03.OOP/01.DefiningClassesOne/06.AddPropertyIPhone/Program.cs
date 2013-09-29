using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefineClassForGSM
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM myGSM = new GSM("Genius Phone", "Bell");

            PhoneBattery mybattery = new PhoneBattery();

            mybattery.HoursIdle = 2;
            mybattery.HoursTalk = 1;
            mybattery.Model = "who knows";
            mybattery.BatteryType = BatteryType.LiIon;

            int size = 10;
            int colors = 256;

            PhoneDisplay myDiplay = new PhoneDisplay(size, colors);

            myGSM.Battery = mybattery;
            myGSM.Display = myDiplay;
            myGSM.Owner = "Me";
            myGSM.Price = 1000000000;

            GSM mySecondGSM = new GSM("unknown","blabla", 1, "me", mybattery, myDiplay);

            GSM myThirdGSM = new GSM("some model", "mlad merin j");

            Console.WriteLine(myThirdGSM.ToString());

            Console.WriteLine(myGSM.ToString());
            Console.WriteLine();
            Console.WriteLine(mySecondGSM.ToString());
            //sorry, dont have time to work on the formating
        }
    }
}
