public class Solution {
    public string ReverseWords(string s) {
        string[] reverse= s.Split(' '); 
        for (int i= 0; i< reverse.Length; i++) {
            char[] arr= reverse[i].ToCharArray();
            Array.Reverse(arr); 
            reverse[i]= new string(arr); 
        } return string.Join(" ", reverse); 
    }
}
