

namespace Planner
{
    public class Building
    {
        public int Stories {get; set;}
        public double Width {get; set;}
        public double Depth {get; set;}
        public double Volume()
        {
            return (Width * Depth * (Stories * 3));
        }

        public string _designer = "Billy Blackman";
        private System.DateTime _dateConstructed;
        public string _address;
        public string _owner;

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = System.DateTime.Now;
        }

        public void Purchase(string owner)
        {
            _owner = owner;
        }
    }
}