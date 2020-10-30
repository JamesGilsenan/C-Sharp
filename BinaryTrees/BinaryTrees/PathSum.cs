using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    class PathSum
    {
        //Challenge. Given a sum, determine if the values of the root to leaf node in a binary tree add up to the given sum

        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;
            else if (root.left == null && root.right == null && sum - root.val == 0)
                return true;
            else
                return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
    }
}
