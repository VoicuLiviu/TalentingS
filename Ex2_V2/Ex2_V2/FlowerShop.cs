using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_V2
{
    public class FlowerShop
    {
        private int totalSales;
        private int totalRevenue;

        public FlowerShop()
        {
            totalSales = 0;
            totalRevenue = 0;
        }

        public void BuyFlower(Flower flower, int quantity)
        {
            totalSales += quantity;
            totalRevenue += flower.Price * quantity;
            Console.WriteLine($"Bought {quantity} {flower.Name}(s) for {flower.Price * quantity} RON.");
        }

        public void BuyBouquet(Bouquet bouquet, int quantity)
        {
            totalSales += quantity;
            totalRevenue += bouquet.Price * quantity;
            Console.WriteLine($"Bought {quantity} {bouquet.Name}(s) for {bouquet.Price * quantity} RON.");
        }

        public void DisplayMonthlyInventory()
        {
            int approximateDays = 30;
            int dailySales = 35;

            int totalMonthlySales = dailySales * approximateDays;
            int totalMonthlyRevenue = (totalRevenue / totalSales) * totalMonthlySales;

            Console.WriteLine($"Approximate Inventory for November:");
            Console.WriteLine($"Total Sales: {totalMonthlySales} items");
            Console.WriteLine($"Total Revenue: {totalMonthlyRevenue} RON");
        }
    }
}
