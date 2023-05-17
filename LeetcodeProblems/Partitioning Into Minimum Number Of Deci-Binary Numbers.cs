public class Solution {
    public int MinPartitions(string n) {
      
      int max = 0;
    
      foreach(char digit in n) {
        int value = digit - '0'; // find max digit value (current digit= ascii- ascii)
        max = Math.Max(max, value); // update max
      }return max;
  }
}