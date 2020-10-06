using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    class LevelOrderTraversal
    {

        public IList<IList<int>> IterativeLevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            //Fail fast
            if (root == null)
                return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();

            //step 0 - push root onto queue
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                int levelSize = queue.Count;
                IList<int> level = new List<int>();

                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode curr = queue.Dequeue();
                    level.Add(curr.val);

                    if (curr.left != null)
                        queue.Enqueue(curr.left);
                    if (curr.right != null)
                        queue.Enqueue(curr.right);
                }
                result.Add(level);
            }

            return result;
        }
    }
}
