using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building BigBillTheBuilding = new Building("123 Bold Bridge Boulevard");
            BigBillTheBuilding.Construct();
            BigBillTheBuilding.Purchase("Bill Buttlicker");

            Building TallTimTheTower = new Building("456 Tootenbacher Trace");
            TallTimTheTower.Construct();
            TallTimTheTower.Purchase("Tony TwoTimer");

            Building SmallSidTheShed = new Building("789 Slick Street");
            SmallSidTheShed.Construct();
            SmallSidTheShed.Purchase("Samantha Sondheim");

            Console.WriteLine(BigBillTheBuilding._address);
            Console.WriteLine("---------");
            Console.WriteLine($"Designed by {BigBillTheBuilding._designer}");
            Console.WriteLine($"Owned by {BigBillTheBuilding._owner}");
            Console.WriteLine($"{BigBillTheBuilding.Volume()} cubic meters of space");
        }
    }
}
