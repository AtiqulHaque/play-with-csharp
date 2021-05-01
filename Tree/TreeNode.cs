using System;
namespace problem_solving.Tree {

    public class TreeNode {
        public String val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode (String val = "", TreeNode left = null, TreeNode right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        
        }
    }
}