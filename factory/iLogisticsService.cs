using factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    // Interface for the Product (LogisticsService)
    public interface iLogisticsService
    {
        void DeliverProduct(string origin, string destination, string product);
    }

    // Concrete Product Class (ShipDelivery)
    public class ShipDelivery : iLogisticsService
    {
        public void DeliverProduct(string origin, string destination, string product)
        {
            Console.WriteLine($"Delivering {product} via ship from {origin} to {destination}");
        }
    }

    // Concrete Product Class (TruckDelivery)
    public class TruckDelivery : iLogisticsService
    {
        public void DeliverProduct(string origin, string destination, string product)
        {
            Console.WriteLine($"Delivering {product} via truck from {origin} to {destination}");
        }
    }


    // Abstract Creator Class (LogisticsCompany)
    public abstract class LogisticsCompany
    {
        public abstract iLogisticsService CreateDeliveryService();

        public void Deliver(string origin, string destination, string product)
        {
            var logisticsService = CreateDeliveryService();
            logisticsService.DeliverProduct(origin, destination, product);
        }
    }

    // Concrete Creator Subclass (ViaShip)
    public class ViaShip : LogisticsCompany
    {
        public override iLogisticsService CreateDeliveryService()
        {
            return new ShipDelivery();
        }
    }

    // Concrete Creator Subclass (ViaTruck)
    public class ViaTruck : LogisticsCompany
    {
        public override iLogisticsService CreateDeliveryService()
        {
            return new TruckDelivery();
        }
    }


    //CLIENt CODE

//    public class Client
//{
//    public static void Main(string[] args)
//    {
//        string origin = "Colombo";
//        string destination = "Hambantota";
//        string product = "Books";

//        // Using ViaShip logistics
//        LogisticsCompany shipCompany = new ViaShip();
//        shipCompany.Deliver(origin, destination, product);

//        // Using ViaTruck logistics
//        LogisticsCompany truckCompany = new ViaTruck();
//        truckCompany.Deliver(origin, destination, product);
//    }
//}


}