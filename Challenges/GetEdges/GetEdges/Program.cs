using GetEdges.Classes;
using System;
using System.Collections.Generic;

namespace GetEdges
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            WeightedNode metro = new WeightedNode("Metroville");
            WeightedNode narnia = new WeightedNode("Narnia");
            WeightedNode naboo = new WeightedNode("Naboo");
            WeightedNode monstro = new WeightedNode("Monstropolis");
            WeightedNode arend = new WeightedNode("Arendelle");
            WeightedNode pand = new WeightedNode("Pandora");

            graph.AddWeightedEdge(metro, narnia, 37);
            graph.AddWeightedEdge(metro, naboo, 26);
            graph.AddWeightedEdge(metro, monstro, 105);
            graph.AddWeightedEdge(metro, arend, 99);
            graph.AddWeightedEdge(metro, pand, 82);

            graph.AddWeightedEdge(narnia, naboo, 250);
            graph.AddWeightedEdge(naboo, monstro, 73);
            graph.AddWeightedEdge(monstro, arend, 42);
            graph.AddWeightedEdge(arend, pand, 150);

            Object result = GetEdges(graph, new string[] { "Metroville", "Pandora" });
            Console.WriteLine(result);
            Console.WriteLine("---");
            result = GetEdges(graph, new string[] { "Arendelle", "Monstropolis", "Naboo" });
            Console.WriteLine(result);
            Console.WriteLine("---");
            result = GetEdges(graph, new string[] { "Naboo", "Pandora" });
            Console.WriteLine(result);
            Console.WriteLine("---");
            result = GetEdges(graph, new string[] { "Narnia", "Arendelle", "Naboo" });
            Console.WriteLine(result);
            Console.WriteLine("---");
        }
        /// <summary>
        /// Method used to grab the weight edges of a direct route. If it exists, then it will
        /// calculate the edge values and return an object with a boolean of true and the cost. 
        /// Else if there is a disconnect in the path, it will return an object with a boolean
        /// of false and 0 for cost.
        /// </summary>
        /// <param name="graph">Graph that is the flights that are connected</param>
        /// <param name="destination">Array of strings with city names</param>
        /// <returns>Object</returns>
        public static Object GetEdges(Graph graph, string[] destination)
        {
            List<WeightedNode> nodeList = graph.GetWeightedNodes();
            int cost = 0;
            int count = 0;

            for (int i = 0; i < destination.Length; i++)
            {
                if (count != i || String.IsNullOrEmpty(destination[i])) return new { IsPossible = false, Cost = 0 };

                foreach (WeightedNode node in nodeList)
                {
                    if (node.Value == destination[i] && (i + 1) < destination.Length)
                    {
                        foreach (WeightedNode child in node.Children.Keys)
                        {
                            if (child.Value == destination[i + 1])
                            {
                                cost = cost + child.Children[node];
                                count++;
                            }
                        }
                    }
                }
            }
            return new { IsPossible = true, Cost = cost };
        }
    }
}
