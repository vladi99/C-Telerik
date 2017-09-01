using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkForDefiningClasses
{
    class GSMTest
    {
        //problem 7
        public void Test()
        {
            List<GSM> gsms = new List<GSM>();
            gsms.Add(new GSM("Asha", "Nokia"));
            gsms.Add(new GSM("4S", "Apple"));
            gsms.Add(new GSM("Galaxy", "Samsung"));
            gsms.Add(new GSM("Lumia", "Nokia"));
            gsms.Add(new GSM("3310", "Nokia"));

            foreach (GSM gsm in gsms)
            {
                Console.WriteLine(gsm);
            }
            Console.WriteLine(GSM.IPhone4S);
        }




    }
}
