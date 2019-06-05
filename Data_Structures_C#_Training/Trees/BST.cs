using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class BST
    {
        private TreeNode root;

        public BST()
        {
            root = null; 
        }      
        
        public void PrintTree()
        {
            PrintHelper(root);
        }

        public bool Remove(int data)
        {
            if (root == null)
                return false;

            TreeNode current = root;
            TreeNode parent = null;
            while (current.Value != data)
            {
                if (current.Value > data)
                {
                    parent = current;
                    current = current.LeftChild;
                }
                else if (current.Value < data)
                {
                    parent = current;
                    current = current.RightChild;
                }
                
                if (current == null)
                    return false;
            }

            if (current.RightChild == null)
            {
                if (parent == null)
                    root = current.LeftChild;
                else
                {
                    if (parent.Value > data)
                        parent.LeftChild = current.LeftChild;
                    else if (parent.Value < data)
                        parent.RightChild = current.LeftChild;
                }
            }
            else if (current.RightChild.LeftChild == null)
            {
                current.RightChild.LeftChild = current.LeftChild;

                if (parent == null)
                    root = current.RightChild;
                else
                {
                    if (parent.Value > data)
                        parent.LeftChild = current.RightChild;
                    else if (parent.Value < data)
                        parent.RightChild = current.RightChild;
                }
            }
            else
            {
                TreeNode leftmost = current.RightChild.LeftChild;
                TreeNode lmParent = current.RightChild;
                while (leftmost.LeftChild != null)
                {
                    lmParent = leftmost;
                    leftmost = leftmost.LeftChild;
                }
                
                lmParent.LeftChild = leftmost.RightChild;
                
                leftmost.LeftChild = current.LeftChild;
                leftmost.RightChild = current.RightChild;

                if (parent == null)
                    root = leftmost;
                else
                {
                    if (parent.Value > data)
                        parent.LeftChild = leftmost;
                    else if (parent.Value < data)
                        parent.RightChild = leftmost;
                }
            }

            return true;
        }

        public int FindMax(TreeNode CurrentNode)
        {
            TreeNode item = CurrentNode;

            while (item.RightChild != null)
            {
                item = item.RightChild;
            }

            return item.Value;
        }

        public void Add(int data)
        {
            TreeNode n = new TreeNode(data, null, null);

            TreeNode current = root, parent = null;
            while (current != null)
            {
                if (current.Value == data)
                    return;
                else if (current.Value > data)
                {
                    parent = current;
                    current = current.LeftChild;
                }
                else if (current.Value < data)
                {
                    parent = current;
                    current = current.RightChild;
                }
            }
           
            if (parent == null)
                root = n;
            else
            {
                if (parent.Value > data)
                    parent.LeftChild = n;
                else
                    parent.RightChild = n;
            }
        }

        private void PrintHelper(TreeNode CurrentNode)
        {
            if (CurrentNode != null)
            {
                PrintHelper(CurrentNode.LeftChild);

                Console.WriteLine(CurrentNode.Value);

                PrintHelper(CurrentNode.RightChild);
            }
        }

    }
}
