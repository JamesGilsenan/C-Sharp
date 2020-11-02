using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    class GivenPreorderAndInorder
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0 || inorder.Length == 0 || preorder.Length != inorder.Length)
                return null;

            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
                dictionary[inorder[i]] = i;

            //pIdx
            int pStart = 0;

            //change return to node
            return HelperNode(preorder, inorder, ref pStart, inorder.Length - 1, 0, dictionary);
        }

        public TreeNode HelperNode(int[] preorder, int[] inorder, ref int pIdx, int inStart, int inEnd, Dictionary<int, int> dictionary)
        {
            if(inStart < inEnd)
            {
                return null;
            }

            int current = preorder[pIdx];
            TreeNode node = new TreeNode(current);

            int inCurrentIdx = dictionary[current];

            pIdx++;

            //recursively build tree by adding left and right nodes
            node.left = HelperNode(preorder, inorder, ref pIdx, inCurrentIdx - 1, inEnd, dictionary);
            node.right = HelperNode(preorder, inorder, ref pIdx, inStart, inCurrentIdx + 1, dictionary);

            //return root node
            return node;
        }
    }
}
