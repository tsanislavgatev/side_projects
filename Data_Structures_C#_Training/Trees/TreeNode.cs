using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class TreeNode
    {
        public int Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public TreeNode(int Value, TreeNode Left, TreeNode Right)
        {
            this.Value = Value;
            this.LeftChild = Left;
            this.RightChild = Right;
        }
    }
}
