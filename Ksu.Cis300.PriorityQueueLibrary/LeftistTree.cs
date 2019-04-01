/* BinaryTreeNode.cs
 * Author: Rod Howell */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KansasStateUniversity.TreeViewer2;

namespace Ksu.Cis300.PriorityQueueLibrary
{
    /// <summary>
    /// An immutable generic binary tree node that can draw itself.
    /// </summary>
    /// <typeparam name="T">The type of the elements stored in the tree.</typeparam>
    public partial class LeftistTree<T> : ITree
    {
        /// <summary>
        /// Gets the data stored in this node.
        /// </summary>
        public T Data { get; }

        /// <summary>
        /// Gets this node's left child.
        /// </summary>
        public LeftistTree<T> LeftChild { get; }

        /// <summary>
        /// Gets this node's right child.
        /// </summary>
        public LeftistTree<T> RightChild { get; }

        /// <summary>
        /// Property that stores the length of the shortest path from the root ro and empty subtree.
        /// </summary>
        private int _nullPath;
        
        /// <summary>
        /// Constructs a BinaryTreeNode with the given data, left child, and right child.
        /// </summary>
        /// <param name="data">The data stored in the node.</param>
        /// <param name="left">The left child.</param>
        /// <param name="right">The right child.</param>
        public LeftistTree(T data, LeftistTree<T> left, LeftistTree<T> right)
        {
            Data = data;
            if (NullPathLength(left) < NullPathLength(right))
            {
                RightChild = left;
                LeftChild = right;
            }
            else
            {
                RightChild = right;
                LeftChild = left;
            }
            _nullPath = NullPathLength(RightChild) + 1;
        }

        /// <summary>
        /// Return the NullPathLength of a given Lefitiest Tree;
        /// </summary>
        /// <param name="t"></param>
        /// <returns>If the given Leftiest Tree is empty it returns 0.
        /// Otherwise it returns the Null Path Length field.</returns>
        public static int NullPathLength(LeftistTree<T> t)
        {
            if (t == null)
                return 0;
            else
                return t._nullPath;
        }

    }
}
