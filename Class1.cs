using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bicycle
    {
        public Bicycle(string v1, string v2, string v3, string v4, string v5)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
            V5 = v5;
        }

        public string V1 { get; }
        public string V2 { get; }
        public string V3 { get; }
        public string V4 { get; }
        public string V5 { get; }
        internal void veight (string v)
        {
            Console.WriteLine(V1 + ":" + v);
        }
        internal void color(string v)
        {
            Console.WriteLine(V1 + ":" + v);
        }
        internal void model(string v)
        {
            Console.WriteLine(V1 + ":" + v);
        }
        internal void speed(string v)
        {
            Console.WriteLine(V1 + ":" + v);
        }
        internal void move (Bicycle v)
        {
            Console.WriteLine("Stels move");
        }
        internal void stop(Bicycle v)
        {
            Console.WriteLine("Stels stop");
        }
    }
}
