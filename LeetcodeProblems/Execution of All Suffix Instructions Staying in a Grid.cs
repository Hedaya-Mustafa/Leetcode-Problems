public class Solution {
    public int[] ExecuteInstructions(int n, int[] startPos, string s) {
        int[] answer= new int[s.Length];

        for (int i= 0; i< s.Length; i++) {
            int row= startPos[0];
            int col= startPos[1];
            
            for (int j = i; j < s.Length; j++) {
                if (s[j]== 'L') {
                    col--;
                } else if (s[j]== 'R') {
                    col++;
                } else if (s[j]== 'U') {
                    row--;
                } else if (s[j]== 'D') {
                    row++;
                }

                if (row< 0 || row>= n || col< 0 || col>= n) {
                    break;
                } 
                answer[i]++;
            }
        }

        return answer;
    }
}
