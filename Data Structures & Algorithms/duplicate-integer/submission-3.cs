public class Solution {
    public bool hasDuplicate(int[] nums) {
    
        HashSet<int> numHash = new HashSet<int>(nums);

        if(numHash.Count != nums.Length){
            return true;
        }
        else{
            return false;
        }
    }
}