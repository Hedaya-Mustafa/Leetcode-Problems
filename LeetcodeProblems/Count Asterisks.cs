public class Solution {
    public int CountAsterisks(string s) {
        int countVerticalBars= 0; 
        int countStars= 0;
        for(int i= 0; i< s.Length; i++){
            if(s[i]=='|'){
                countVerticalBars++;
            } else if(countVerticalBars%2== 0 && s[i]=='*'){
                countStars++;
            }
            
        } return countStars;
    }
}