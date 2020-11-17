using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    class PopulatingNextRightPointer2
    {
        public Node Connect(Node root)
        {
            Node nextNode = root;

            if (nextNode == null)
                return null;
            if (nextNode.left == null && nextNode.right == null)
                return root;

            while (nextNode != null || nextNode.left != null || nextNode.right != null)
            {
                PopulateNextHelper(nextNode);
                if (nextNode.left != null)
                    nextNode = nextNode.left;
                else if (nextNode.right != null)
                    nextNode = nextNode.right;
            }

            return root;
        }

        public void PopulateNextHelper(Node startNode)
        {
            Node currentNode = startNode;

            while(currentNode != null)
            {
                if (currentNode.left != null)
                {

                }

                currentNode = currentNode.next;
            }
        }
    }
}
