using System;

namespace ClassNode
{
    public class Node
    {
        public int num
        { get; set; }
        public double x
        { get; set; }
        public double y
        { get; set; }
        public double z
        { get; set; }
        public Node(int num = 1,
        double x = 0.0,
        double y = 0.0,
        double z = 0.0)
        {
            this.num = num;
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return $"n={num,10}, x={x,10:g3}, y={y,10:g3}, z={z,10:g3}";
        }
    }
}
