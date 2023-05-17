public class Solution {
    public int BalancedStringSplit(string s) {

        int R= 0, L= 0, output= 0;
        for(int i=0; i< s.Length; i++){
            if(s[i] == 'R'){ 
                R++;
            } else if(s[i] == 'L'){ 
                L++;
            }
            if(R == L){
                output++;
                R = 0; 
                L = 0;
            }
        } return output;
    }
}