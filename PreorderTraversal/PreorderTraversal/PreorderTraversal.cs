using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    //visit the root, visit the left subtree, visit the right subtree
    class PreorderTraversal
    {
        public IList<int> RecursivePreorder(TreeNode root)
        {
            IList<int> values = new List<int>();
            TreeNode previous = root;
            Helper(root, values);
            return values;
        }

        static void Helper(TreeNode root, IList<int> values)
        {
            if (root != null)
            {
                values.Add(root.val);
                if (root.left != null)
                {
                    Helper(root.left, values);
                }
                if (root.right != null)
                {
                    Helper(root.right, values);
                }    
            }
        }
    }
}
