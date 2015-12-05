using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class GSMCallHistoryTest
    {
        static void Main(string[] args)
        {
            //Create instance of class GSM
            GSM MyPhone = new GSM("E52", "Nokia" );

        
            //Add few calls
            MyPhone.AddCalls(DateTime.Now, "0888888", 58);
            MyPhone.AddCalls(DateTime.Now, "08398392", 120);
            MyPhone.AddCalls(DateTime.Now, "09878903234", 213);
            MyPhone.AddCalls(DateTime.Now, "12345643", 22);

            //Display information about calls
            for (int i = 0; i < MyPhone.CallHistory.Count; i++)
            {
                Console.WriteLine("Call number {0}", i);
                Console.WriteLine("Duration: {0} seconds", MyPhone.CallHistory[i].Duration);
                Console.WriteLine("Dailed number:{0}", MyPhone.CallHistory[i].DialedNumbers);
                Console.WriteLine();

            }

            //Calculate and print the total price
            Console.WriteLine("Total price is {0} leva", MyPhone.TotalPrice(0.37));
            Console.WriteLine();

            //Remove longest call from history
            int longCallByDuration = LongestCall(MyPhone);
            MyPhone.DeleteCall(longCallByDuration);
            Console.WriteLine(MyPhone.ToString());  // override ToString form GSM class

            //Print total price after removing longest call
            Console.WriteLine("Total price after removing longest call is {0} leva",MyPhone.TotalPrice(0.37));
            
            //Clear call history and print it
            MyPhone.ClearCallHistory();

            int proba = 443;
            
            
        }

        //Method for finding call with maximal duration
        public static int LongestCall(GSM MyPhone)
        {
            int currentCallDuration = 0;
            int maxCallDuration = 0;
            int indexOfLongestCallByDuration = 0;
            for (int i = 0; i < MyPhone.CallHistory.Count; i++)
            {
                currentCallDuration = MyPhone.CallHistory[i].Duration;
                if (currentCallDuration > maxCallDuration)
                {
                    maxCallDuration = currentCallDuration;
                    indexOfLongestCallByDuration = i;

                }

            }
            return indexOfLongestCallByDuration;
        }
    }
}



