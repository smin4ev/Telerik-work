using System;
using System.Collections.Generic;
using System.Text;


namespace _5.NumberOfWorkdays
{
    //Write a method that calculates the number of workdays between today and given date, 
    //passed as parameter. Consider that workdays are all days from Monday to Friday except 
    //a fixed list of public holidays specified preliminary as array.

    class NumberOfWorkdays
    {
        static void Main()
        {
            Console.WriteLine("Enter a end date of the period in following form - YYYY/MM/DD");
            DateTime endDay = DateTime.Parse(Console.ReadLine());
            

            DateTime[] holyday = {// new DateTime(2013,01,01),
                                  // new DateTime(2013,03,03),
                                  // new DateTime(2013,05,01),
                                   new DateTime(2013,09,06),
                                   //new DateTime(2013,09,22),
                                   //new DateTime(2013,10,01),
                                  // new DateTime(2013,12,24),
                                   //new DateTime(2013,12,25),
                                   //new DateTime(2013,12,31)            
                                 };
            DateTime today = DateTime.Today;

            if (endDay < today)
            {
                Console.WriteLine("Enter date is pass.Result will be incorect, so endDay and today will be changed!!");
                DateTime temporary = today;
                today = endDay;
                endDay = temporary;
            }

            int allWorkDaysInPerion = (endDay - today).Days; 


            while(today<=endDay)
            {
                if ((today.DayOfWeek == DayOfWeek.Saturday) || (today.DayOfWeek == DayOfWeek.Sunday))
                {
                    allWorkDaysInPerion = allWorkDaysInPerion - 1;
                    

                }
                else
                {
                    for (int i = 0; i < holyday.Length; i++)
                    {
                        if (today == holyday[i])
                        {
                            allWorkDaysInPerion = allWorkDaysInPerion - 1;
                        }
                    }
                }
                today = today.AddDays(1);
            }
            Console.WriteLine(allWorkDaysInPerion);

        }
    }
}
