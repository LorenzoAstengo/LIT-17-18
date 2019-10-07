using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    public class Graph
    {
        public class Node
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public Node(string name)
            {
                this.name = name;
            }
        }

        public class Arch
        {
            private Node startNode;
            public Node StartNode
            {
                get { return startNode; }
                set { startNode = value; }
            }

            private Node endNode;
            public Node EndNode
            {
                get { return endNode; }
                set { endNode = value; }
            }

            public Arch(Node start, Node end)
            {
                startNode = start;
                endNode = end;
            }
        }

        public List<Node> nodes;

        public List<Arch> arches;

        public Graph(List<Node> nodes, List<Arch> arches)
        {
            this.nodes = nodes;
            this.arches = arches;            
        }

        public Node[] Subgraphs()
        {
            int countArr = 0;
            List<Node[]> subgraphs = new List<Node[]>();
            Node[] result = new Node[nodes.Capacity];
            foreach (Arch arch in arches)
            {
                Node[] arr = new Node[2];
                arr[0] = arch.StartNode;
                arr[1] = arch.EndNode;
                subgraphs.Add(arr);
            }
            result[countArr] = subgraphs[0][0];
            countArr++;
            result[countArr] = subgraphs[0][1];
            countArr++;

            foreach (var element in result)
            {
                foreach (var subgraph in subgraphs)
                {
                    if (subgraphs[0] == subgraph) { }
                    else if (element == subgraph[0] && !result.Contains(subgraph[1]))
                    {
                        result[countArr] = subgraph[1];
                        countArr++;
                    }
                    else if (element == subgraph[1] && !result.Contains(subgraph[1]))
                    {
                        result[countArr] = subgraph[0];
                        countArr++;
                    }
                }
            }
            return result;
        }
    }
}
