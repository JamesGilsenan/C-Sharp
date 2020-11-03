using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            /* IsSymmetrical Test
            TreeNode node7 = new TreeNode(4, null, null);
            TreeNode node6 = new TreeNode(4, null, null);
            TreeNode node5 = new TreeNode(3, null, null);
            TreeNode node4 = new TreeNode(3, null, null);
            TreeNode node3 = new TreeNode(2, null, node7);
            TreeNode node2 = new TreeNode(2, null, node6);
            TreeNode node1 = new TreeNode(1, node2, node3);
            */
            /* Path Sum Test
            TreeNode node9 = new TreeNode(1, null, null);
            TreeNode node8 = new TreeNode(2, null, null);
            TreeNode node7 = new TreeNode(7, null, null);
            TreeNode node6 = new TreeNode(4, null, node9);
            TreeNode node5 = new TreeNode(13, null, null);
            TreeNode node4 = new TreeNode(11, node7, node8);
            TreeNode node3 = new TreeNode(8, node5, node7);
            TreeNode node2 = new TreeNode(4, node4, null);
            TreeNode node1 = new TreeNode(5, node2, node3);
            */
            /*Construct Tree given inorder and postorder Test
            int[] inorder = new int[] { 9, 3, 15, 20, 7 };
            int[] postorder = new int[] { 9, 15, 7, 20, 3 };
            */
            /*Construct Tree given Preorder and Inorder Test
            int[] preorder = new int[] { 3, 9, 20, 15, 7 };
            int[] inorder = new int[] { 9, 3, 15, 20, 7 };
            */
            //Populate Next Pointers in a perfect Binary Tree
            Node node7 = new Node(7, null, null, null);
            Node node6 = new Node(6, null, null, null);
            Node node5 = new Node(5, null, null, null);
            Node node4 = new Node(4, null, null, null);
            Node node3 = new Node(3, node5, node7, null);
            Node node2 = new Node(2, node4, node5, null);
            Node node1 = new Node(1, node2, node3, null);

            MaximumDepth maxDepth = new MaximumDepth();
            IsSymmetric symmetric = new IsSymmetric();
            PathSum pathSum = new PathSum();
            GivenInorderAndPostorder buildTree1 = new GivenInorderAndPostorder();
            GivenPreorderAndInorder buildTree2 = new GivenPreorderAndInorder();
            PopulatingNextRightPointer populateNext = new PopulatingNextRightPointer();


            //Console.WriteLine("Max depth of tree: " + maxDepth.MaxDepth(node1));
            //Console.WriteLine("Binary Tree is symmetric: " + symmetric.CheckSymmetry(node1));
            //Console.WriteLine("Binary Tree has root to leaf path with sum: " + pathSum.HasPathSum(node1, 22));
            //Console.WriteLine("Constructing Binary Tree...\nRoot node: " + buildTree1.BuildTree(inorder, postorder).val);
            //Console.WriteLine("Constructing Binary Tree...\nRoot node: " + buildTree2.BuildTree(preorder, inorder).val);
            Console.WriteLine("Populating Next Pointers of a perfect Binary Tree...\n" + populateNext.Connect(node1).val);

            Console.Read();
        }
    }
}
