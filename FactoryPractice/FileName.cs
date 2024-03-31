using System;

namespace FactoryPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FurnitureFactory factory = new FurnitureFactory();

            var chair = factory.CreateFurniture(FurnitureType.Chair, "Wood", "Pink");
            chair.Customize();

            var table = factory.CreateFurniture(FurnitureType.Table, "Metal", "Black");
            table.Customize();
        }
    }

    public interface ICustomizable
    {
        void Customize(string material = null, string color = null);
    }

    class Chair : ICustomizable
    {
        public void Customize(string material = null, string color = null)
        {
            Console.WriteLine($"The Chair is made using:");
            if (material != null) Console.WriteLine($"  Material: {material}");
            if (color != null) Console.WriteLine($"  Color: {color}");
        }
    }

    class Table : ICustomizable
    {
        public void Customize(string material = null, string color = null)
        {
            Console.WriteLine($"The Table is made using:");
            if (material != null) Console.WriteLine($"  Material: {material}");
            if (color != null) Console.WriteLine($"  Color: {color}");
        }
    }

    // Possibly add a Sofa class implementing ICustomizable

    public enum FurnitureType { Chair, Table, Sofa } // Assuming a Sofa class exists

    abstract class FurnitureFactory
    {
        public abstract ICustomizable CreateFurniture(FurnitureType type, string material = null, string color = null);
    }

    class ChairFactory : FurnitureFactory
    {
        public override ICustomizable CreateFurniture(FurnitureType type, string material = null, string color = null)
        {
            if (type == FurnitureType.Chair)
                return new Chair { Material = material, Color = color };
            else
                throw new ArgumentException("Invalid furniture type provided to ChairFactory");
        }
    }

    class TableFactory : FurnitureFactory
    {
        public override ICustomizable CreateFurniture(FurnitureType type, string material = null, string color = null)
        {
            if (type == FurnitureType.Table)
                return new Table { Material = material, Color = color };
            else
                throw new ArgumentException("Invalid furniture type provided to TableFactory");
        }
    }

    // Possibly add SofaFactory class
}
