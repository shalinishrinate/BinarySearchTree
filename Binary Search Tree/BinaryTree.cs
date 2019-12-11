using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class BinaryTree
    {
        //variables

        Node root;
        Node currentNode;

        //constructor
        //public BinaryTree()
        //{
           
        //}

        //method

        public void Add(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
                return;
            }
            else
            {
                currentNode = root;
                while (true)
                {

                    if (data < currentNode.data)
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = node;
                            break;
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
                            break;
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
}

