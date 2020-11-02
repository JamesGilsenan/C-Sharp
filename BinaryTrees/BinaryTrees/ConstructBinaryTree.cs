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

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            //to find root, last element in postorder array = root
            //left subtree = everything left of root in inorder array
            //right sub tree = everything right of root in postorder array

            //if there are 0 nodes, there is no tree to build. If both arrays don't have the same amount of values,  Return null
            if (inorder.Length == 0 || postorder.Length == 0 || inorder.Length != postorder.Length)
                return null;

            //Use Dictionary (Hashmap) to store inorder as key, value pairs.
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
                dictionary[inorder[i]] = i;

            int pStart = postorder.Length - 1;

            //call recursive method to build each node and return root node
            return BuildNode(inorder, postorder, ref pStart, 0, inorder.Length - 1, dictionary);
        }

        public TreeNode BuildNode(int[] inorder, int[] postorder, ref int pIdx, int inStart, int inEnd, Dictionary<int, int> dictionary)
        {
            //base case
            if (inStart > inEnd)
                return null;
            //node as no children, return node
            //else if (inStart == inEnd)
            //    return new TreeNode(postorder[inStart]);

            int current = postorder[pIdx];
            TreeNode node = new TreeNode(current);

            //Look up values using postorder values as key
            int inCurrentIdx = dictionary[current];

            pIdx--;
            node.right = BuildNode(inorder, postorder, ref pIdx, inCurrentIdx + 1, inEnd, dictionary);
            node.left = BuildNode(inorder, postorder, ref pIdx, inStart, inCurrentIdx - 1, dictionary);

            return node;
        }

    }
}
