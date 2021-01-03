using System;

namespace ClassNode
{
    public class Point
    {
        public double x
        { get; set; }
        public double y
        { get; set; }
        public double z
        { get; set; }
        public static double tolerance
        { get; set; }
        public Point(
        double x = 0.0,
        double y = 0.0,
        double z = 0.0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            tolerance = 1e-6;
        }
        public static Point operator *(double s, Point p) => new Point(s * p.x, s * p.y, s * p.z);
        public static Point operator *(Point p, double s) => new Point(s * p.x, s * p.y, s * p.z);
        public static double operator *(Point p1, Point p2) => p1.x * p2.x + p1.y + p2.y + p1.z * p2.z;
        public static Point operator +(Point p) => new Point(p.x, p.y, p.z);
        public static Point operator -(Point p) => new Point(-p.x, -p.y, -p.z);
        public static Point operator +(Point p1, Point p2) => new Point(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
        public static Point operator -(Point p1, Point p2) => new Point(p1.x - p2.x, p1.y - p2.y, p1.z - p2.z);

        public static bool operator ==(Point p1, Point p2)
        {
            return Math.Abs(p1.x - p2.x) <= tolerance &
                   Math.Abs(p1.y - p2.y) <= tolerance &
                   Math.Abs(p1.z - p2.z) <= tolerance;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return Math.Abs(p1.x - p2.x) <= tolerance &
                   Math.Abs(p1.y - p2.y) <= tolerance &
                   Math.Abs(p1.z - p2.z) <= tolerance;
        }

        public double length
        {
            get => Math.Sqrt(x * x + y * y + z * z);
            set
            {
                Point rez = this.normalized * value;
                x = rez.x;
                y = rez.y;
                z = rez.z;
            }

        }
        public Point normalized
        {
            get
            {
                double l = this.length;
                if (l > 0)
                    return new Point(x / l, y / l, z / l);
                else
                    return new Point(0, 0, 0);
            }

        }

        public void Normalize()
        {
            double l = this.length;
            if (l > 0)
            {
                x /= l;
                y /= l;
                z /= l;
            }
        }

        public override string ToString()
        {
            return $"({x,10:g3}, {y,10:g3}, {z,10:g3})";
        }
    }

    public class Node : Point
    {
        public int num
        { get; set; }

        public Node(int num = 0,
        double x = 0.0,
        double y = 0.0,
        double z = 0.0) : base(x: x, y: y, z: z)
        {
            this.num = num;
        }

        public override string ToString()
        {
            return $"n={num,10}, x={x,10:g3}, y={y,10:g3}, z={z,10:g3}";
        }
    }
}
