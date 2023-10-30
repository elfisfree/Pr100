using System;

namespace Pr100.Classes
{
    class Scooter : Transport
    {
        public string NumberOfWheels { get; set; }
        public string Engine { get; set; }
        public new bool IsRented { get; set; }

        public Scooter(string speed, string color, string model, string licenseCategory, string numberOfWheels, string engine, bool isRented)
            : base(speed, color, model, licenseCategory, isRented)
        {
            NumberOfWheels = numberOfWheels;
            Engine = engine;
            IsRented = isRented;
        }

        public override void PrintInfo()
        {
            
    }
}
