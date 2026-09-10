public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char,int> D = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (D.ContainsKey(s[i]))
            {
                D[s[i]]++;
            }
            else
            {
                D[s[i]] = 1;
            }
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (!D.ContainsKey(t[i]))
            {
                return false;
            }
            else
            {
                D[t[i]]--;
            }
        }

        foreach (int val in D.Values)
        {
            if (val != 0)
            {
                return false;
            }
        }

        return true;
    }
}