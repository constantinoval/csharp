using System;
using ClassNode;
using System.Collections;
using System.Collections.Generic;

namespace ClassModel
{
    public class Model
    {
        public Dictionary<int, Node> nodes;
        public Model()
        {
            nodes = new();
        }
        public override string ToString()
        {
            return $"Model contains: {nodes.Count} nodes";
        }
        public void PrintNodes()
        {
            System.Console.WriteLine("Model nodes:");
            foreach (Node n in nodes.Values)
            {
                System.Console.WriteLine($"\t {n}");
            }
        }
    }
}
