using System;

namespace algoritmlesson5
{
    public class Node
    {
        public Node left;
        public Node right;
        public int data;
        public Node(int data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }
        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;

        }
    }
}