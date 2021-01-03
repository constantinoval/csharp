using System;
using ClassNode;
using ClassModel;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Model m = new();
            for (int i = 1; i <= 10; i++)
            {
                Node n = new(num: i, x: i * 0.1);
                m.nodes[n.num] = n;
            }
            Console.WriteLine(m);
            m.PrintNodes();
        }
    }
}
