using System.Collections.Generic;
using System;

namespace BinaryTreeTraversal
{
    // Visit left subtree, visit the root, visit the right subtree
    class InorderTraversal
    {
        public IList<int> RecursiveInorder(TreeNode root)
        {
            IList<int> values = new List<int>();
            Helper(root, values);
            return values;
        }
       
        static void Helper(TreeNode root, IList<int> values)
        {
            if (root != null)
            {
                if (root.left != null)
                    Helper(root.left, values);
                values.Add(root.val);
                if (root.right != null)
                    Helper(root.right, values);
            }
        }
        
        public IList<int> IterativeInorder(TreeNode root)
        {
            IList<int> values = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode curr = root;

            while (curr != null || stack.Count != 0)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                values.Add(curr.val);
                curr = curr.right;
            }

            return values;
        }
        
    }
}
