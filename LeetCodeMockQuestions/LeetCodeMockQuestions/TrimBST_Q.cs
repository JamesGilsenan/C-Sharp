using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMockQuestions
{
    class TrimBST_Q
    {
        //Given the root of a binary search tree and the lowest and highest boundaries as low and high, trim the tree so that all its elements lies in [low, high]. 
        //Trimming the tree should not change the relative structure of the elements that will remain in the tree (i.e., any node's descendant should remain a descendant). 
        //It can be proven that there is a unique answer.
        //Return the root of the trimmed binary search tree.Note that the root may change depending on the given bounds.

        public TreeNode TrimBST(TreeNode root, int low, int high)
        {
            //values less than rrot.val will be on left subtree. values greater than root.val will be in right subtree
            //fail fast
            if (root == null)
                return root;

            //if root.val < low, root.val is too low, check if root.right.val is inside bounds I.E. right side will have higher value
            if (root.val < low)
                return TrimBST(root.right, low, high);

            //if root.val > high, root.val is too high, check if root.left.val is inside bounds I.E. left side will have lower value
            if (root.val > high)
                return TrimBST(root.left, low, high);

            //if we reach this point, root.val was inside bounds. Progress to left and right nodes
            root.left = TrimBST(root.left, low, high);
            root.right = TrimBST(root.right, low, high);

            return root;
        }
    }
}
