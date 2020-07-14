public class Solution {
    public TreeNode SearchBST(TreeNode root, int val) {
        if(root == null){
            return null;
        }
        while(root != null){
            if(root.val == val){
                return root;
            }
            else if(root.val <val){
                root = root.right;
            }
            else if(root.val >val){
                root = root.left;
            }
        }
        return null;
    }
}