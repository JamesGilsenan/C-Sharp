using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    class IsSymmetric
    {
        public bool CheckSymmetry(TreeNode root)
        {
            return iterativeSymmetric(root);
            //return recursiveSolution(root, root);
        }

        public bool iterativeSymmetric(TreeNode root)
        {
            // to check if tree is a mirror of itself, the left child on the left side should match the right child on the right side

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode leftNode = queue.Dequeue();
                TreeNode rightNode = queue.Dequeue();

                if (leftNode == null && rightNode == null)
                    continue;
                if (leftNode == null || rightNode == null)
                    return false;
                if (leftNode.val != rightNode.val)
                    return false;

                queue.Enqueue(leftNode.left);
                queue.Enqueue(rightNode.right);
                queue.Enqueue(leftNode.right);
                queue.Enqueue(rightNode.left);
            }
            return true;
        }

        public bool recursiveSolution(TreeNode leftNode, TreeNode rightNode)
        {
            if (leftNode == null && rightNode == null)
                return true;
            if (leftNode == null || rightNode == null)
                return false;

            return (leftNode.val == rightNode.val)
                && recursiveSolution(leftNode.right, rightNode.left)
                && recursiveSolution(leftNode.left, rightNode.right);
        }
    }
}
