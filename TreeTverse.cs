using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Compression;
using System.Runtime.Versioning;
using problem_solving.Tree;

namespace problem_solving
{
    public class TreeTverse
    {
             static TreeNode insertLevelWise (TreeNode root, string key) {

            Queue<TreeNode> queue = new Queue<TreeNode> ();

            queue.Enqueue (root);

            while (queue.Count > 0) {
                TreeNode temp = queue.Peek ();
                queue.Dequeue ();

                if (temp.left == null) {
                    temp.left = new TreeNode (key, null, null);
                    break;
                } else {
                    queue.Enqueue (temp.left);

                    if (temp.right == null) {
                        temp.right = new TreeNode (key, null, null);
                        break;
                    } else {
                        queue.Enqueue (temp.right);
                    }

                }

            }

            return root;

        }

        static void inOrderTraverse (TreeNode root) {
            Stack<TreeNode> treeStack = new Stack<TreeNode> ();

            TreeNode TempRoot = root;

            while (true) {

                if (treeStack.Count == 0 && TempRoot == null) {
                    break;
                }

                while (TempRoot != null) {
                    treeStack.Push (TempRoot);
                    TempRoot = TempRoot.left;
                }

                TempRoot = treeStack.Pop ();
                System.Console.WriteLine (TempRoot.val);
                TempRoot = TempRoot.right;

            }
        }

        static void levelOrderTraversal (TreeNode root) {
            Queue<TreeNode> queue = new Queue<TreeNode> ();

            queue.Enqueue (root);
            System.Console.WriteLine (root.val);

            while (queue.Count > 0) {
                TreeNode temp = queue.Peek ();
                queue.Dequeue ();

                if (temp.left != null) {
                    System.Console.WriteLine (temp.left.val);
                    queue.Enqueue (temp.left);
                }

                if (temp.right != null) {
                    System.Console.WriteLine (temp.right.val);
                    queue.Enqueue (temp.right);
                }

            }

        }
    
    }
}