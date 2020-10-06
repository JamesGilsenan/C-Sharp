using System;
//using System.Collections;
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
                //levelSize = number of nodes on current level
                int levelSize = queue.Count;
                IList<int> level = new List<int>();

                //for number of nodes in level, add 
                for (int i = 0; i < levelSize; i++)
                {
                    //node = next node in queue
                    TreeNode curr = queue.Dequeue();
                    //add current node value to this level's list
                    level.Add(curr.val);

                    //if curr node has left or right child nodes, add them to queue
                    if (curr.left != null)
                        queue.Enqueue(curr.left);
                    if (curr.right != null)
                        queue.Enqueue(curr.right);
                    //repeat loop by moving to next node in level
                }
                //after all nodes in level have been traversed, add level list to result list and move to next level. Repeat steps while queue isn't empty(nodes to be visited)
                result.Add(level);
            }

            return result;
        }
    }
}
