public class Solution {
    public string RestoreString(string s, int[] indices) {
        
        char[] shuffledArr = new char[s.Length];

        for (int i = 0; i < s.Length; i++) {
            shuffledArr[indices[i]] = s[i];
        } return new string(shuffledArr);
    }
}