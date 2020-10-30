using System;

namespace BinaryTrees
{
    class MaximumDepth
    {
        private int answer;

        public int MaxDepth(TreeNode root)
        {
            answer = TopDown(root, 0);
            return answer;
        }

        public int TopDown(TreeNode root, int depth)
        {
            if (root == null)
                return depth;


            if (root.left == null && root.right == null)
                answer = Math.Max(answer, depth);

            TopDown(root.left, depth + 1);
            TopDown (root.right, depth + 1);

            //account for first node in tree
            return answer + 1;
        }
    }
}
