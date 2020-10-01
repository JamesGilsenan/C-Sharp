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
            

            IList<int> values = inorder.RecursiveInorder(node1);

            foreach (int value in values)
            {
                Console.Write(value + ", ");
            }
            
            Console.Read();
        }
    }
}
