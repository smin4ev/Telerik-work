using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentsAndWorkers
{
    public class Worker : Human
    {
        private int weekSelary;
        private int workHoursPerDay;

        public int WeekSelary
        {
            get { return this.weekSelary; }
            set { this.weekSelary = value; }  
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public Worker(string firstName, string lastName, int weekSelary, int workHoursPerDay): base(firstName, lastName)
        {
            this.WeekSelary = weekSelary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = (weekSelary / 5) /workHoursPerDay;
            return moneyPerHour;
        }
    }
}
