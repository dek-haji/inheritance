using System;

namespace inheritance1
{
    public class Tesla : Vehicle{  // Electric car
    public void ChargeBattery () {
            Console.WriteLine("its charging");
        }
         public override void Drive()
        {
            Console.WriteLine("Tesla aint a joke, it blazes u like vruuuuuum");
        }
          public override void Turn(string direction)
        {
            direction = "left";
            Console.WriteLine($"the car turns {direction}");
        }
        public  override void Stop()
        {
            Console.WriteLine("white tesla is about to stop");
            Console.WriteLine("-------------------");
        }
}
}