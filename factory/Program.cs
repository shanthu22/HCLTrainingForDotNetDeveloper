using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origin = "Colombo";
            string destination = "Hambantota";
            string product = "Books";

            // Using ViaShip logistics
            LogisticsCompany shipCompany = new ViaShip();
            shipCompany.Deliver(origin, destination, product);

            // Using ViaTruck logistics
            LogisticsCompany truckCompany = new ViaTruck();
            truckCompany.Deliver(origin, destination, product);
        }
    }
}
