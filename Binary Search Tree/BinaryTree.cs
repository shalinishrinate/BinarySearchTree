using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BinaryTree
    {
        //variables
    
        Node root;
        Node currentNode;

        //constructor
        public BinaryTree(int data)
        {
            root = null;  
        }

        //method

        public void Add(int data)
        {
            Node node = new Node();
            if (root == null)
            {
                root = node;
                return;
            }
            else
            {
                currentNode = root;

                if (data < currentNode.data)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = node;
                    }
                    else if (currentNode.left != null)
                    {
                        currentNode = currentNode.left;
                    }
                }
                else if (data > currentNode.data)
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = node;
                    }
                    else if (currentNode.right != null)
                    {
                        currentNode = currentNode.right;
                    }
                }
            }
        }

    }
}
