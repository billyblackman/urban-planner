using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building BigBillTheBuilding = new Building("123 Bold Bridge Boulevard");
            BigBillTheBuilding.Width = 1;
            BigBillTheBuilding.Depth = 20;
            BigBillTheBuilding.Stories = 10;
            BigBillTheBuilding.Construct();
            BigBillTheBuilding.Purchase("Bill Buttlicker");

            Building TallTimTheTower = new Building("456 Tootenbacher Trace");
            TallTimTheTower.Width = 7.00;
            TallTimTheTower.Depth = 3.00;
            TallTimTheTower.Stories = 1;
            TallTimTheTower.Construct();
            TallTimTheTower.Purchase("Tony TwoTimer");

            Building SmallSidTheShed = new Building("789 Slick Street");
            SmallSidTheShed.Width = 500;
            SmallSidTheShed.Depth = 300;
            SmallSidTheShed.Stories = 1;
            SmallSidTheShed.Construct();
            SmallSidTheShed.Purchase("Samantha Sondheim");

            City NittyGrittyCity = new City();
            NittyGrittyCity.Mayor = "Greta Goobertensen";
            NittyGrittyCity.YearEstablished = 2020;
            NittyGrittyCity.AddBuilding(BigBillTheBuilding);

            NittyGrittyCity.AddBuilding(SmallSidTheShed);

            foreach(Building building in NittyGrittyCity.Buildings)
            {
                building.WriteBuildingInfo();
            }
        }
    }
}