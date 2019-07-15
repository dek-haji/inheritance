using System;

namespace inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero airforce1 = new Zero();
            Tesla Xs = new Tesla();
            Cessna Yamaha = new Cessna();
            Xs.MainColor = "Red";
            Console.WriteLine(Xs.MainColor);
            Yamaha.Drive();
            Xs.Drive();
            airforce1.Drive();
            airforce1.Turn("right");
            Xs.Stop();
            Xs.Turn("right");
            Yamaha.Drive();
            Yamaha.Turn("grey");
            Yamaha.Stop();
            airforce1.Drive();
            airforce1.Turn("anywhere");
            airforce1.Stop();

        }
    }
}
