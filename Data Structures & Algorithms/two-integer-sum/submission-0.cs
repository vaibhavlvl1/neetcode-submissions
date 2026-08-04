public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> D = new Dictionary<int,int>();

        for(int i = 0;i<nums.Length;i++)
        {   
            var diff = target-nums[i];
            if( D.ContainsKey(diff))
            {
                return [D[diff],i];
            }

            else 
            {
                D[nums[i]] = i;
            }
        }

        return [];
    }
}
