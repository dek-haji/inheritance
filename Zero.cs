using System;
namespace inheritance1
{
    public class Zero : Vehicle{  // Electric motorcycle

    public void ChargeBattery () { 
        Console.WriteLine("its charging");
     }
      public override void Drive()
        {
            Console.WriteLine("black zero zipz by you zzzzfff");
        }
         public override void Turn(string direction)
        {
            direction = "left";
            Console.WriteLine($"the airplane turns {direction}");
        }
        public  override void Stop()
        {
            Console.WriteLine("red zero is about to land");
            Console.WriteLine("-------------------");
        }
}
}