using System;
using Xunit;
using Graphs.Classes;
using System.Collections.Generic;

namespace GraphTests
{
    public class UnitTest1
    {
        [Fact]
        public void SuccessfullyAddAnEdge()
        {
            Graph graph = new Graph(new Node(1));
            Node pointA = new Node(2);

            graph.AddEdge(graph.Root, pointA);

            Assert.Equal(graph.Root.Children[0], pointA);
        }
        [Fact]
        public void GetSizeofGivenGraph()
        {
            Graph graph = new Graph(new Node(1));
            Node pointA = new Node(2);
            Node pointB = new Node(3);
            Node pointC = new Node(4);
            Node pointD = new Node(5);

            graph.AddEdge(graph.Root, pointA);
            graph.AddEdge(pointA, pointB);
            graph.AddEdge(pointB, pointC);
            graph.AddEdge(pointC, pointD);

            Assert.Equal(5, graph.Size());
        }
        [Fact]
        public void GetNeighborsOfExisitingNode()
        {
            Graph graph = new Graph(new Node(1));
            Node pointA = new Node(2);
            Node pointB = new Node(3);
            Node pointC = new Node(4);
            Node pointD = new Node(5);

            graph.AddEdge(graph.Root, pointA);
            graph.AddEdge(pointA, pointB);
            graph.AddEdge(pointB, pointC);
            graph.AddEdge(pointC, pointD);

            List<Node> neighbors = graph.GetNeighbors(pointC);

            Assert.Equal(3, neighbors[0].Value);
            Assert.Equal(5, neighbors[1].Value);
        }
        [Fact]
        public void ReturnNullIfNoNeighborsExist()
        {
            Graph graph = new Graph(new Node(1));
            List<Node> neighbors = graph.GetNeighbors(new Node(5));
            Assert.Null(neighbors);
        }
    }
}
