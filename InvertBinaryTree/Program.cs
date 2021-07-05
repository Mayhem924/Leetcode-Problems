using System;

namespace InvertBinaryTree
{
    class TreeNode
    {
        public TreeNode left;
        public TreeNode right;

        public int val;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;

            var leftNode = InvertTree(root.left);
            var rightNode = InvertTree(root.right);

            root.right = leftNode;
            root.left = rightNode;

            return root;
        }
    }
}
