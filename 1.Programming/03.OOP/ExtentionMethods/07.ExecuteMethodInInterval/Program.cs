/*Using delegates write a class Timer that can execute certain method at each t seconds. http://msdn.microsoft.com/en-us/library/system.threading.timercallback.aspx
*/

using System;
using System.Threading;

class TimerExample
{
    static void Main()
    {
        // Create an event to signal the timeout count threshold in the 
        // timer callback.
        AutoResetEvent autoEvent = new AutoResetEvent(false);

        // Create an inferred delegate that invokes methods for the timer.
        TimerCallback tcb = PrintCurrentTime;

        // Create a timer that signals the delegate to invoke  
        // PrintCurrentTime after one second, and every 1 second  
        // thereafter.

        Console.WriteLine("{0} Creating timer.\n", DateTime.Now.ToString("hh:mm:ss"));

        Timer stateTimer = new Timer(tcb, autoEvent, 1000, 1000);

        while (true)
        {
            autoEvent.Set();
        }
    }
    static void PrintCurrentTime(Object stateInfo)
    {
        Console.WriteLine("{0}", DateTime.Now.ToString("hh:mm:ss"));
    }
}