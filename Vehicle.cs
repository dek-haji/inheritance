using System;

namespace inheritance1
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public double FuelCapacity { get; set; }
        public string MaximumOccupancy { get; set; }

        public double BatteryKWh { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom");
        }
        public virtual void Turn(string direction)
        {
            direction = "right";
            Console.WriteLine($"the car turns {direction}");
        }
        public virtual void Stop()
        {
            Console.WriteLine("the vehicle almost is about to stop");
        }
    }
}