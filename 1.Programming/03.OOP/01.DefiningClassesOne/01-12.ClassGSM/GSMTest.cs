using System;
using System.Collections.Generic;

public class GSMTest
{
    public static void TestGSM()
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
    }
}
