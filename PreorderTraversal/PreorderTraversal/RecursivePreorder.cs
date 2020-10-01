using System.Collections.Generic;
using System.Collections;

namespace PreorderTraversal
{
    class RecursivePreorder
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> values = new List<int>();
            TreeNode previous = root;
            Helper(root, values);
            //Helper(root, values);
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
