using System;
using System.Collections.Generic;
using Graphs.Classes;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(new Node(1));
            Node pointA = new Node(2);
            Node pointB = new Node(3);
            Node pointC = new Node(4);
            Node pointD = new Node(5);
            Node pointE = new Node(6);
            Node pointF = new Node(7);

            graph.AddEdge(graph.Root, pointA);
            graph.AddEdge(pointA, pointB);
            graph.AddEdge(pointB, pointC);
            graph.AddEdge(pointC, pointD);
            graph.AddEdge(pointD, pointA);
            graph.AddEdge(pointD, pointE);
            graph.AddEdge(pointF, pointE);

            Console.WriteLine("Breadth First");
            List<Node> breadth = graph.BreadthFirst(graph.Root);
            //AdjacencyList
            //1->2
            //2->1->3->5
            //3->2->4
            //4->3->5
            //5->4->1->6
            //6->5->7
            //7->6
            foreach(Node child in breadth)
            {
                Console.WriteLine(child.Value);
            }
            Console.WriteLine("-----");
            //pointD = 4
            //4->2->6
            Console.WriteLine("Get Neighbors of pointD");
            List<Node> children = graph.GetNeighbors(pointD);
            foreach (Node child in children)
            {
                Console.WriteLine(child.Value);
            }
            Console.WriteLine("-----");
            //All nodes
            //1,2,3,4,5,6,7
            Console.WriteLine("Get All nodes");
            List<Node> nodes = graph.GetNodes();
            foreach (Node child in nodes)
            {
                Console.WriteLine(child.Value);
            }

        }
    }
}
