using System;
using System.Collections.Generic;


namespace BinaryTreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node5 = new TreeNode(5, null, null);
            TreeNode node4 = new TreeNode(4, null, null);
            TreeNode node3 = new TreeNode(3, null, null);
            TreeNode node2 = new TreeNode(2, node4, node5);
            TreeNode node1 = new TreeNode(1, node2, node3);
            PreorderTraversal preorder = new PreorderTraversal();
            InorderTraversal inorder = new InorderTraversal();
            PostorderTraversal postorder = new PostorderTraversal();
            
            IList<int> recursiveValues = postorder.RecursivePostorder(node1);
            IList<int> iterativeValues = postorder.IterativePostorder(node1);

            Console.Write("Recursive values: ");
            foreach (int value in recursiveValues)
            {
                Console.Write(value + ", ");
            }

            Console.Write("\nIterative values: ");
            foreach (int value in iterativeValues)
            {
                Console.Write(value + ", ");
            }

            Console.Read();
        }
    }
}
