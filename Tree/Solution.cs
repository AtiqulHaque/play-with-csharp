// using System.Collections.Generic;

// namespace problem_solving.Tree
// {
//     public class Solution {
//         public IList<int> PreorderTraversal(TreeNode root) {

//              List<int> res = new List<int>();
        
//             if(root == null)
//                 return res;
            
//             res.Add(root.val);
            
//             res.AddRange(PreorderTraversal(root.left));
//             res.AddRange(PreorderTraversal(root.right));
            
//             return res;
//         }
//     }


// }