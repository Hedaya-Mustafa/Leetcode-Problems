public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string merged= "";
        int i= 0, j= 0;
        while ((i < word1.Length) && (j < word2.Length)) 
            merged+= word1[i++]+ "" +word2[j++];
        
        while (i< word1.Length) 
            merged+= word1[i++];
        
        while (j< word2.Length) 
            merged+= word2[j++];
        
        return merged;
    }
}
