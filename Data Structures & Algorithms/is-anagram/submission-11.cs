public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char ,int> D = new Dictionary<char,int>();

        foreach(char letter in s)
        {
            if(D.ContainsKey(letter))
            {
                D[letter] = D[letter] + 1;
            }
            else
            {
                D[letter] = 1;
            }
        }

        foreach(char letter in t)
        {
            if(!D.ContainsKey(letter))
            {
                return false;
            }
            else
            {
                D[letter] = D[letter] - 1;
            }
        }

        foreach(int value in D.Values)
        {
            if(value != 0)
            {
                return false;
            }
        }

        return true;
    }
}
