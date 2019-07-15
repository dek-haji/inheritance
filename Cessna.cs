using System;
namespace inheritance1
{
    public class Cessna : Vehicle
    {  // Propellor light aircraft

        public void RefuelTank()
        {
            Console.WriteLine("tank is getting full");
        }
        public override void Drive()
        {
            Console.WriteLine("white cessna flashes you like a hurricane. zzzoooom");
        }
         public override void Turn(string direction)
        {
            direction = "right";
            Console.WriteLine($"the car turns {direction}");
        }
        public  override void Stop()
        {
            Console.WriteLine("blue Cessna  is about to stop");
            Console.WriteLine("-------------------");
        }
    }
}
