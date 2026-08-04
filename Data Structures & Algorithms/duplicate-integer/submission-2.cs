public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> D = new Dictionary<int,int>();

       foreach(int number in nums)
       {
        if(D.ContainsKey(number))
        {
            D[number] = D[number] + 1;
        }
        else{
            D[number] = 1;
        }
        if(D[number]>1)
        {
            return true;
        }
       }

       foreach(int value in D.Values){
        if (value > 1)
        {
            return true;
        }
       }

       return false;
    }
}