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
            LevelOrderTraversal levelorder = new LevelOrderTraversal();

            //IList<IList<int>> recursiveValues = levelorder.RecursiveLevelOrder(node1);
            IList<IList<int>> iterativeValues = levelorder.IterativeLevelOrder(node1);

            /*
            Console.Write("Recursive values: ");
            foreach (int value in recursiveValues)
            {
                Console.Write(value + ", ");
            }
            */

            Console.Write("\nIterative values: ");
            Console.WriteLine("\n[");
            foreach (List<int> level in iterativeValues)
            {
                Console.Write("[");
                foreach (int value in level)
                {
                    Console.Write(value + ", ");
                }
                Console.WriteLine("]");
            }
            Console.Write("]");

            Console.Read();
        }
    }
}
