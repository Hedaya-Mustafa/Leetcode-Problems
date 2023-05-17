public class Solution {
    public string OptimalDivision(int[] nums) {

       if (nums.Length == 1) {
            return nums[0].ToString();

        } else if (nums.Length == 2) {
            return nums[0].ToString() + '/' + nums[1].ToString();

        } else {
            string output = nums[0].ToString() + "/(" + nums[1].ToString();
            for (int i = 2; i < nums.Length; i++) {
                output += '/' + nums[i].ToString();
                
            }
            return output += ')';
        }
    }
}