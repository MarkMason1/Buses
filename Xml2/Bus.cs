namespace Xml2
{
    public class Bus
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string MaxSpeed { get; set; }
        public string MaxCapacity { get; set; }
        public string AmountOfWheels { get; set; }

        public Bus(string _brand, string _model, string _maxSpeed, string _maxCap, string _amOfWheels)
        {
            Brand = _brand;
            Model = _model;
            MaxSpeed = _maxSpeed;
            MaxCapacity = _maxCap;
            AmountOfWheels = _amOfWheels;
        }
    }
}