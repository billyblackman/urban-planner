using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building BigBillTheBuilding = new Building("123 Bold Bridge Boulevard");
            BigBillTheBuilding.Width = 10000;
            BigBillTheBuilding.Depth = 15000;
            BigBillTheBuilding.Stories = 10;
            BigBillTheBuilding.Construct();
            BigBillTheBuilding.Purchase("Bill Buttlicker");

            Building TallTimTheTower = new Building("456 Tootenbacher Trace");
            TallTimTheTower.Width = 1000;
            TallTimTheTower.Depth = 1500;
            TallTimTheTower.Stories = 100;
            TallTimTheTower.Construct();
            TallTimTheTower.Purchase("Tony TwoTimer");

            Building SmallSidTheShed = new Building("789 Slick Street");
            SmallSidTheShed.Width = 500;
            SmallSidTheShed.Depth = 300;
            SmallSidTheShed.Stories = 1;
            SmallSidTheShed.Construct();
            SmallSidTheShed.Purchase("Samantha Sondheim");

            Console.WriteLine(BigBillTheBuilding._address);
            Console.WriteLine("---------");
            Console.WriteLine($"Designed by {BigBillTheBuilding._designer}");
            Console.WriteLine($"Owned by {BigBillTheBuilding._owner}");
            Console.WriteLine($"{BigBillTheBuilding.Volume()} cubic meters of space");

            BigBillTheBuilding.WriteBuildingInfo();
            TallTimTheTower.WriteBuildingInfo();
            SmallSidTheShed.WriteBuildingInfo();
        }
    }
}