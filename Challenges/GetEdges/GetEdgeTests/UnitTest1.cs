using System;
using Xunit;
using GetEdges.Classes;
using GetEdges;
using System.Reflection;

namespace GetEdgeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckThatFlightPathIsPossible()
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

            Object result = Program.GetEdges(graph, new string[] { "Metroville", "Pandora" });

            PropertyInfo value = result.GetType().GetProperty("IsPossible");
            bool possible = (bool)(value.GetValue(result, null));
            Assert.True(possible);
        }
        [Fact]
        public void CheckThatFlightPathIsNotPossible()
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

            Object result = Program.GetEdges(graph, new string[] { "Nabo", "Pandora" });

            PropertyInfo value = result.GetType().GetProperty("IsPossible");
            bool possible = (bool)(value.GetValue(result, null));
            Assert.False(possible);
        }
        [Fact]
        public void CheckThatArrayHasOneCity()
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

            Object result = Program.GetEdges(graph, new string[] { "Pandora" });

            PropertyInfo value = result.GetType().GetProperty("IsPossible");
            bool possible = (bool)(value.GetValue(result, null));
            Assert.True(possible);
        }
        [Fact]
        public void CheckThatArrayHasAnyEmptyValues()
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

            Object result = Program.GetEdges(graph, new string[] { "" });

            PropertyInfo value = result.GetType().GetProperty("IsPossible");
            bool possible = (bool)(value.GetValue(result, null));
            Assert.False(possible);
        }

    }
}
