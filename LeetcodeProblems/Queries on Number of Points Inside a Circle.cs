public class Solution {
    public int[] CountPoints(int[][] points, int[][] queries) {
        int[] answer = new int[queries.Length];

        for( int i= 0; i< queries.Length; i++) {
            for(int j= 0; j< points.Length; j++) {
            
                if(( points[j][0]- queries[i][0])* ( points[j][0]- queries[i][0])
                 + ( points[j][1]- queries[i][1])* ( points[j][1]- queries[i][1]) 
                 <= queries[i][2]* queries[i][2]) {
                    
                    answer[i]++;
                }
            }
        }

        return answer;
    }
}