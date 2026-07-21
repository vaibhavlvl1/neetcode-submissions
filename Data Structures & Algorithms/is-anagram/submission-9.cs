public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        Dictionary<char, int> D = new Dictionary<char, int>();

        foreach (char letter in s) {
            if (!D.ContainsKey(letter)) {
                D[letter] = 1;
            }
            else if (D.ContainsKey(letter)) {
                D[letter] = D[letter] + 1;
            }
        }

        foreach (char letter in t) {
            if(!D.ContainsKey(letter)){
               return false;
            }
            D[letter] = D[letter] - 1;
        }

        foreach(int count in D.Values) {
            if(count != 0){
                return false;
            }
            
        }  
        return true;
        
    }
}
