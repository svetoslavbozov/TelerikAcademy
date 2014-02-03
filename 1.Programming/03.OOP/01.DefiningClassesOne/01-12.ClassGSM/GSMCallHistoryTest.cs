using System;
using System.Linq;

public class GSMCallHistoryTest
{
    public static void TestCallHistory()
    {
        //instance of gsm
        GSM myGsm = new GSM("WTF-5610", "Samsung", 0, "Me");

        PhoneBattery myGsmBattery = new PhoneBattery("who knows", 5, 10);
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

        //Clear call history and print it (which is not very logical thing to do by the way :)
        myGsm.CallHistory.Clear();

        foreach (var item in myGsm.CallHistory)
        {
            Console.WriteLine(item.ToString());
        }

        Console.WriteLine(myGsm.CallsTotalCost(0.37));
        Console.WriteLine();

    }
}

