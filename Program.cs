using System;

namespace algoritmlesson5
{
    partial class Program
    {
        /*
              ____(6)____
             /		                \
        (2)	                   (11)
        /   \                    /    \
    (4)    (3)           (9)     (30)
                                              \
                                                (12)
         */
        static Node sample_tree()
        {
            Node root = new Node(6,
                new Node(2,
                new Node(4), new Node(3)),
                new Node(11,
                new Node(9), new Node(30,
                new Node(12), null)));
            return root;
        }
        static void Main(string[] args)
        {
            Node tree = sample_tree();
            Console.Write("BFS: "); bfs(tree);
            Console.WriteLine();
            Console.Write("DFS: "); dfs(tree);
        }
    }
}