public class Solution {
    public int MostWordsFound(string[] sentences) {
        int maxNumOfWords= 0;
        for(int i= 0; i< sentences.Length; i++){
            maxNumOfWords = Math.Max(maxNumOfWords, sentences[i].Split(' ').Count());
        }
        return maxNumOfWords;    
    }
}