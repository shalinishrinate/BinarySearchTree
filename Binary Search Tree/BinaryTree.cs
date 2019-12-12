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
                root = node; // root of the tree is declared
                return;
            }
            else
            {
                currentNode = root; // if root is not null then it becomes the currentnode

                while (true)
                {
                    if (data < currentNode.data) // if the value of currentnode is more than the int data
                    {
                        if (currentNode.left == null) // and if the node to the left is null
                        {
                            currentNode.left = node;    // then that becomed the left node
                            break;
                        }
                        else if (currentNode.left != null) // but if the left node is not null
                        {
                            currentNode = currentNode.left; // currentnode left becomes the current node
                        }
                    }
                    else if (data > currentNode.data) // if the currentnode is less then the int data
                    {
                        if (currentNode.right == null) // and node to the right is null
                        {
                            currentNode.right = node; // then that becomes the right node
                            break;
                        }
                        else if (currentNode.right != null) // but if the right node is not null
                        {
                            currentNode = currentNode.right;// then right becomes the current node
                        }
                    }
                }
            }
        }
        public bool Search(int inputData)
        {
            if (inputData == root.data) // if the data entered is equal to the root value
            {
                Console.WriteLine("Found the number!"); // then its a match
                return true;
            }

            currentNode = root; //now the current node 
            while (true) // condition
            {
                if (inputData < currentNode.data)
                {
                    if (currentNode.left == null)
                    {
                        return false;
                    }
                    else if (currentNode.left.data == inputData)
                    {
                        Console.WriteLine("Found the number!");
                        return true;
                    }
                    else
                    {
                        currentNode = currentNode.left;//new currentnode
                    }

                }
                if (inputData > currentNode.data)
                {
                    if (currentNode.right == null)
                    {
                        return false;
                    }
                    else if (currentNode.right.data == inputData)
                    {
                        Console.WriteLine("Found the number!");
                        return true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }

                }
            }
        }
    }
}

