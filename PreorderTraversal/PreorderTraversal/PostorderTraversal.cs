using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    class PostorderTraversal
    {
        public IList<int> RecursivePostorder(TreeNode root)
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
                if (root.right != null)
                    Helper(root.right, values);
                values.Add(root.val);
            }
        }
    }
}
