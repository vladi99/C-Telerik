using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkForDefiningClasses
{
    class GSMCallHistoryTest
    {
        public void TestHistoryCalls()
        {
            GSM myGSM = new GSM("Asha", "Nokia");

            List<Call> calls = new List<Call>();
            for (int i = 0; i < 6; i++)
            {
                calls.Add(new Call(DateTime.Now, DateTime.Now, "088888888", "0888888878", i + 0.3));
            }
            foreach (var call in calls)
            {
                myGSM.AddCalls(call);
            }

            double money = myGSM.CalculateTotalPrice(0.37);
            Console.WriteLine("Spent money for calls: {0}", money);
            double longestDuration = 0;
            int indexOfLongestCall = 0;
            for (int i = 0; i < calls.Count; i++)
            {
                if (calls[i].Duration >= longestDuration)
                {
                    longestDuration = calls[i].Duration;
                    indexOfLongestCall = i;
                }
            }
            myGSM.DeleteCalls(calls[indexOfLongestCall]);
            money = myGSM.CalculateTotalPrice(0.37);
            Console.WriteLine("Spent money for calls after removing the longest: {0}", money);

            for (int i = 0; i < myGSM.CallHistory.Count; i++)
            {
                Console.WriteLine("{0} called {1} for {2} minutes at {3}", myGSM.CallHistory[i].Number, myGSM.CallHistory[i].DialedPhone, myGSM.CallHistory[i].Duration, myGSM.CallHistory[i].Time);
            }

            myGSM.ClearCallHistory();
        }
    }
}
