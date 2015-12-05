using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class GSMTest
    {
        private GSM[] phones = new GSM[3] {new GSM("Galaxy", "Samsung"), new GSM("Lumia", "Nokia", 500, "Pesho"), new GSM("6230","Nokia")};

        public void InformationForPhones()
        {
            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i].ToString());
            }
        }
        public void InformationForIphone4s()
        {
            GSM Iphone = new GSM("Iphone" , "Apple");
            Console.WriteLine(Iphone.IPhone4s.ToString());
        }
        
            
        

    }
}
