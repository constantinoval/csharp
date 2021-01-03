using System;
using ClassNode;
using ClassModel;
using System.Linq;

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
            //Node.tolerance = 0.5;
            // System.Console.WriteLine(m.nodes[1] == m.nodes[1]);
            // System.Console.WriteLine(m.nodes[1] == m.nodes[2]);
            // System.Console.WriteLine(m.nodes[5].length);
        }
    }
}
