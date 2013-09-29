/*Write a class GSMTest to test the GSM class:
Create an array of few instances of the GSM class.
Display the information about the GSMs in the array.
Display the information about the static property IPhone4S.
*/

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
            List<GSM> gsmList = new List<GSM>();

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

            GSM mySecondGSM = new GSM("unknown", "blabla", 1, "me", mybattery, myDiplay);

            GSM myThirdGSM = new GSM("some model", "mlad merin j");

            gsmList.Add(myGSM);
            gsmList.Add(mySecondGSM);
            gsmList.Add(myThirdGSM);

            foreach (var item in gsmList)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(GSM.IPhone.ToString());
            //sorry, dont have time to work on the formating
        }
    }
}
