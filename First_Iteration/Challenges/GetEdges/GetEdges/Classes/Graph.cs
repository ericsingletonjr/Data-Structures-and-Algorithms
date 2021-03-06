﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdges.Classes
{
    public class Graph
    {
        public Node Root { get; set; }
        public List<Node> Nodes { get; set; } = new List<Node>();
        public List<WeightedNode> WeightedNodes { get; set; } = new List<WeightedNode>();

        public Graph(Node node)
        {
            Root = node;
            Nodes.Add(node);
        }

        public Graph()
        {

        }

        /// <summary>
        /// Method that is used to take in two nodes and add a connection 
        /// between them. It checks to see if the node already exists in the
        /// graph and if it doesn't, it will add the node to the graph.
        /// </summary>
        /// <param name="pointA">First node in the connection</param>
        /// <param name="pointB">Second node in the connection</param>
        public void AddEdge(Node pointA, Node pointB)
        {
            if (!Nodes.Contains(pointA))
            {
                Nodes.Add(pointA);
            }
            if (!Nodes.Contains(pointB))
            {
                Nodes.Add(pointB);
            }

            pointA.Children.Add(pointB);
            pointB.Children.Add(pointA);
        }
        /// <summary>
        /// Method to added two weighted nodes to a graph and the value of the
        /// edge between them
        /// </summary>
        /// <param name="pointA">Weighted node for the first point</param>
        /// <param name="pointB">Weighted node for the second point</param>
        /// <param name="weight">the weight that is assigned to the edge</param>
        public void AddWeightedEdge(WeightedNode pointA, WeightedNode pointB, int weight)
        {
            if (!WeightedNodes.Contains(pointA))
            {
                WeightedNodes.Add(pointA);
            }
            if (!WeightedNodes.Contains(pointB))
            {
                WeightedNodes.Add(pointB);
            }

            pointA.Children.Add(pointB, weight);
            pointB.Children.Add(pointA, weight);
        }

        /// <summary>
        /// Method that grabs the size of the Nodes property
        /// </summary>
        /// <returns>A long value</returns>
        public long Size() => Nodes.Count;

        /// <summary>
        /// Method to grab all the nodes in the graph
        /// </summary>
        /// <returns>List of Nodes</returns>
        public List<Node> GetNodes() => Nodes;

        public List<WeightedNode> GetWeightedNodes() => WeightedNodes;

        /// <summary>
        /// Method used to grab neighbors of the given node. It checks if the node
        /// exsists and if it does, it will return its children or a null
        /// </summary>
        /// <param name="parent">Node to be checked</param>
        /// <returns>Childen of given node or null if node has no children</returns>
        public List<Node> GetNeighbors(Node parent) => Nodes.Contains(parent) ? parent.Children : null;

        /// <summary>
        /// This Method traverses the graph in a breadth first fashion. It will flag each child as true if visited
        /// in order to break out of the loop once it circles around.
        /// </summary>
        /// <param name="root">Root node of the graph</param>
        /// <returns>A list in an Adjacency List</returns>
        public List<Node> BreadthFirst(Node root)
        {
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);
            root.Visited = true;

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                order.Add(front);

                foreach (Node child in front.Children)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        breadth.Enqueue(child);
                    }
                }
            }
            return order;
        }
    }
}
