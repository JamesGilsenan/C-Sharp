using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    //Postorder traversal - visit the left subtree, visit the right subtree, visit the root
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

        //add values at index 0 so they are being added to the start of the list
        //reverse of postorder, visit root, visit right subtree, visit left subtree
        public IList<int> IterativePostorder(TreeNode root)
        {
            IList<int> values = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            
            while (root != null || stack.Count != 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    values.Insert(0, root.val);
                    root = root.right;
                }
                root = stack.Pop();
                if (!values.Contains(root.val))
                    values.Add(root.val);
                root = root.left;
                
            }
            return values;
        }
        
    }
}
