public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {

        int[] maxRows = new int[grid.Length]; 
        int[] maxCols = new int[grid[0].Length]; 
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                maxRows[i] = Math.Max(maxRows[i], grid[i][j]);
                maxCols[j] = Math.Max(maxCols[j], grid[i][j]);
            }
        }

        int maxTotalSum = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                int ans= Math.Min(maxRows[i], maxCols[j]) - grid[i][j];
                maxTotalSum += ans;
            }
        } return maxTotalSum;
    }
}