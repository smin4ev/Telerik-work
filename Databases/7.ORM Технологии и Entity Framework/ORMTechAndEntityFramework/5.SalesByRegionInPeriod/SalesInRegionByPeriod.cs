using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.CreateDbContext;

namespace _5.SalesByRegionInPeriod
{
    class SalesInRegionByPeriod
    {
        static void Main(string[] args)
        {
            SalesByRegionAndPeriod(1997, 2002, "BC");
        }

        static void SalesByRegionAndPeriod(int startData, int endDate, string region)
        {
            var northwindDBcontent = new NorthwindEntities();
            using (northwindDBcontent)
            {
                var sales = northwindDBcontent.Orders
                    .Where(o => o.OrderDate.Value.Year >= startData && o.ShippedDate.Value.Year <= endDate && o.ShipRegion == region);

                foreach (var sale in sales)
                {
                    Console.WriteLine("Data of order - {0}, data of shipping - {1}, Region - {2}", sale.OrderDate, sale.ShippedDate, sale.ShipRegion);
                   
                }

            }
        }

    }
}
