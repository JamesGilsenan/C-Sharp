using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    class PopulatingNextRightPointer
    {
        //You are given a perfect binary tree where all leaves are on the same level, and every parent has two children.
        //Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.
        //Initially, all next pointers are set to NULL.

        public Node Connect(Node root)
        {
            Node leftNode = root;

            //checks there is a level below
            while(leftNode != null && leftNode.left != null)
            {
                //call helper with leftNode = root to populate next pointers
                PopulateNextHelper(leftNode);
                //advance left node to first node in next level
                leftNode = leftNode.left;
            }

            return root;
        }

        public void PopulateNextHelper(Node startNode)
        {
            Node currentNode = startNode;

            //currentNode will be advanced to next node in level at end of while loop
            while (currentNode != null)
            {
                //populate left child node's next pointer = right child node
                currentNode.left.next = currentNode.right;

                //if there is a next node, we haven't reached the last node in the level
                if (currentNode.next != null)
                {
                    //set the next pointer of the right child node = left child node of node on current level in right subtree
                    currentNode.right.next = currentNode.next.left;
                }
                //advance current node to next node on current level. If next node is null, while loop doesn't execute and method ends
                currentNode = currentNode.next;

            }
        }
    }
}
