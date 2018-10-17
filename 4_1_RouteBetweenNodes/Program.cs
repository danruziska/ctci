using MyGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_RouteBetweenNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Node> nodes = new List<Node>();
            nodes.Add(new Node<int>(0));
            nodes.Add(new Node<int>(1));
            nodes.Add(new Node<int>(2));
            nodes.Add(new Node<int>(3));
            nodes.Add(new Node<int>(4));
            nodes.Add(new Node<int>(5));

            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge(nodes[0], nodes[1]));
            edges.Add(new Edge(nodes[0], nodes[2]));
            edges.Add(new Edge(nodes[1], nodes[3]));
            edges.Add(new Edge(nodes[1], nodes[4]));
            edges.Add(new Edge(nodes[4], nodes[5]));

            Graph graph = new Graph(edges, nodes);
        }

        static bool IsRouteAvailable(Graph graph, Node node1, Node node2)
        {
            node1.OutboundEdges[0].To
        }
    }
}
