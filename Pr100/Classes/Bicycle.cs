using System;

namespace Pr100.Classes
{
    class Bicycle : Transport
    {
        public new bool IsRented { get; set; }
        public Bicycle(string speed, string color, string model, string licenseCategory, bool isRented)
            : base(speed, color, model, licenseCategory, isRented)
        {
            IsRented = isRented;
        }

        public override void PrintInfo()
        {
            
        }
    }
}
