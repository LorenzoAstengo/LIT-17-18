using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercise08;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise08
    {
        [TestMethod]
        public void TestFindingSubgraphs()
        {
            Graph.Node node = new Graph.Node("A");
            Graph.Node node1 = new Graph.Node("B");
            Graph.Node node2 = new Graph.Node("C");

            Graph.Arch arch = new Graph.Arch(node, node1);
            Graph.Arch arch2 = new Graph.Arch(node1, node2);

            List<Graph.Node> nodes = new List<Graph.Node>();
            nodes.Add(node);
            nodes.Add(node1);
            nodes.Add(node2);
            List<Graph.Arch> arches = new List<Graph.Arch>();
            arches.Add(arch);
            arches.Add(arch2);
            Graph graph = new Graph(nodes, arches);

            var result = graph.Subgraphs();

            for (int i = 0; i < nodes.ToArray().Length; i++)
            {
                Assert.AreEqual((nodes.ToArray())[i], result[i]);
            }
        }

        [TestMethod]
        public void TestFindingSubgraphsWithANodeNotConnected()
        {
            Graph.Node node = new Graph.Node("A");
            Graph.Node node1 = new Graph.Node("B");
            Graph.Node node2 = new Graph.Node("C");
            Graph.Node node3 = new Graph.Node("D");

            Graph.Arch arch = new Graph.Arch(node, node1);
            Graph.Arch arch2 = new Graph.Arch(node1, node2);

            List<Graph.Node> nodes = new List<Graph.Node>();
            nodes.Add(node);
            nodes.Add(node1);
            nodes.Add(node2);
            nodes.Add(node3);
            List<Graph.Arch> arches = new List<Graph.Arch>();
            arches.Add(arch);
            arches.Add(arch2);
            Graph graph = new Graph(nodes, arches);

            var result = graph.Subgraphs();
            Graph.Node[] expectedResult = { node, node1, node2 };

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }

        [TestMethod]
        public void TestFindingSubgraphs2()
        {
            Graph.Node node = new Graph.Node("A");
            Graph.Node node1 = new Graph.Node("B");
            Graph.Node node2 = new Graph.Node("C");
            Graph.Node node3 = new Graph.Node("D");
            Graph.Node node4 = new Graph.Node("E");
            Graph.Node node5 = new Graph.Node("F");

            Graph.Arch arch = new Graph.Arch(node, node1);
            Graph.Arch arch2 = new Graph.Arch(node, node3);
            Graph.Arch arch3 = new Graph.Arch(node, node4);
            Graph.Arch arch4 = new Graph.Arch(node4, node2);

            List<Graph.Node> nodes = new List<Graph.Node>();
            nodes.Add(node);
            nodes.Add(node1);
            nodes.Add(node2);
            nodes.Add(node3);
            nodes.Add(node4);
            nodes.Add(node5);
            List<Graph.Arch> arches = new List<Graph.Arch>();
            arches.Add(arch);
            arches.Add(arch2);
            arches.Add(arch3);
            arches.Add(arch4);
            Graph graph = new Graph(nodes, arches);

            var result = graph.Subgraphs();
            Graph.Node[] expectedResult = { node, node1, node3, node4, node2 };

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }
    }
}
