using System.Collections.Generic;

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
    }
}
