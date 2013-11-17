/*

8. C:\Users\admin-pc\Documents\Visual Studio 2013\Projects\TelerikAcademy\1.Programming\03.OOP\01.DefiningClassesOne\07.WriteClassGSMTest\GSM.cs
 
9.Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.

10.Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.

11.Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.

12.Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
Create an instance of the GSM class.
    Add few calls.
    Display the information about the calls.
    Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
    Remove the longest call from the history and calculate the total price again.
    Finally clear the call history and print it.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CreateClassCalls
{
    class GSMCallHistoryTest
    {
        static void Main(string[] args)
        {
            //instance of gsm
            GSM myGsm = new GSM("WTF-5610","Samsung",0,"Me");

            PhoneBattery myGsmBattery = new PhoneBattery("who knows", 5,10);
            myGsmBattery.BatteryType = BatteryType.LiIon;

            PhoneDisplay mygGsmDisplay = new PhoneDisplay(5, 256);

            myGsm.Battery = myGsmBattery;
            myGsm.Display = mygGsmDisplay;

            //few calls
            Calls call1 = new Calls(DateTime.Now, 15, "+35911111111");
            Calls call2 = new Calls(DateTime.Now, 20, "+35922222222");
            Calls call3 = new Calls(DateTime.Now, 30, "+35933333333");

            myGsm.CallHistory.Add(call1);
            myGsm.CallHistory.Add(call2);
            myGsm.CallHistory.Add(call3);

            //display call history
            foreach (var item in myGsm.CallHistory)
            {
                Console.WriteLine(item.ToString());
            }

            //print total calls cost
            Console.WriteLine(myGsm.CallsTotalCost(0.37));

            //remove longest call and calculate price again
            Calls longestCall = myGsm.CallHistory.OrderBy(x => x.Duration).Last();
            myGsm.CallHistory.Remove(longestCall);

            Console.WriteLine(myGsm.CallsTotalCost(0.37));

            //Clear call history and print it ( which is not very logical thing to do by the way :)
            myGsm.CallHistory.Clear();

            foreach (var item in myGsm.CallHistory)
            {
                Console.WriteLine(item.ToString());
            }





            Console.WriteLine(myGsm.CallsTotalCost(0.37));
            Console.WriteLine();

        }
    }
}
