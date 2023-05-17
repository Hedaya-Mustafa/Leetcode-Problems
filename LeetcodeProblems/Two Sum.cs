public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int [] answer = new int[2];

        for (int i = 0; i < nums.Length; i++){
            for (int j = nums.Length - 1; j > i; j--){
                if (target == nums[i] + nums[j]){
                    answer[0] = Array.IndexOf(nums, nums[i]);
                    answer[1] = Array.IndexOf(nums, nums[j], Array.IndexOf(nums, nums[i]) + 1);
                }
            }
        }
        return answer;
    }}
