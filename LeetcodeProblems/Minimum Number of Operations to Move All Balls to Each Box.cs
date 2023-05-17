public class Solution {
    public int[] MinOperations(string boxes) {

        int n = boxes.Length;
        int[] answer = new int[n];
        int min = 0;
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < n; j++) {
                if(boxes[j] == '1') {
                    min += Math.Abs(i-j);
                }
            }
            answer[i] = min;
            min = 0;
        }
        return answer;
    }
}