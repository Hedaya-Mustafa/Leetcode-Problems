public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int[] answer;
        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
         if (nums[counter] != nums[i])
         {
             nums[++counter] = nums[i];
         }   
        }
        return ++counter;
        
    }
}

