using System;
namespace algoritmlesson5
{
    partial class Program
    {
        static void dfs(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.data + " ");
            dfs(node.left);
            dfs(node.right);
        }
    }
}