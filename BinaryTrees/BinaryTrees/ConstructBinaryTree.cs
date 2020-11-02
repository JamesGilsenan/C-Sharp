using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    class ConstructBinaryTree
    {
        //Given inorder and postorder traversal of a tree, construct the binary tree.
        //Inorder traversal - Visit left subtree, visit root, visit right subtree
        //Postorder Traversal - Visit left subtree, visit right subtree, visit root

        private int postIndex;
        private int inorderRoot;
        private int nodes;
        

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            //to find root, last element in postorder array = root
            //left subtree = everything left of root in inorder array
            //right sub tree = everything right of root in postorder array

            nodes = postorder.Length;
            inorderRoot = GetRoot(inorder, postorder[nodes - 1]);

            //if there are 0 nodes, there is no tree to build. Return null
            if (nodes == 0)
                return null;
            else if (inorder.Length != postorder.Length)
                return null;
            //else, there are nodes i.e. tree to build. Set index = root, last element in postorder
            postIndex = postorder.Length - 1;

            //call recursive method to build each node and return root node


            return BuildNode(inorder, postorder, 0, nodes - 1);
        }

        public TreeNode BuildNode(int[] inorder, int[] postorder, int inStart, int inEnd)
        {
            //base case
            if (inStart > inEnd)
                return null;

            //find index of root in inorder array
            /*
            int rootInorder = -1;
            for (int i = inEnd; i >= inStart; i--)
            {
                if (inorder[i] == postIndex)
                {
                    rootInorder = i;
                    break;
                }
            }
            */

            TreeNode node = new TreeNode(postorder[postIndex - 1]);

            node.right = BuildNode(inorder, postorder, inorderRoot + 1, inEnd);
            node.left = BuildNode(inorder, postorder, inStart, inorderRoot - 1);

            //change this to node to return
            return node;
        }

        public int GetRoot(int[] array, int value)
        {
            int i = 0;
            for (i = 0; i < nodes; i++)
                if (array[i] == value)
                    break;
            return i;
        }

    }
}
