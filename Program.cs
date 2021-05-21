using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle Stels = new Bicycle( "Stels", "60 kg", "Yellow", "Spotrs", "30 km/h");
            Stels.veight("60 kg");
            Stels.color("Yellow");
            Stels.model("Sports");
            Stels.speed("30 km/h");
            Stels.move(Stels);
            Stels.stop(Stels);
        }
    }
}
