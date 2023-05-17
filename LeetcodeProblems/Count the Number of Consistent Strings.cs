public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int count= 0;
        for (int i= 0; i< words.Length; i++) {
            bool isConsistent = true;
            for (int j= 0; j< words[i].Length; j++) {
                if (!allowed.Contains(words[i][j])) 
                    isConsistent = false;  
            }
            if (isConsistent) 
                count++;
            
        } return count;
    }
}
