public class Solution {
    public double AverageWaitingTime(int[][] customers) {
        int workingTime = 0;
        double waitingTimeSum = 0;

        for (int i = 0; i < customers.Length; i++) { 
            int arrival = customers[i][0], time = customers[i][1], finishTime = workingTime;

            if (arrival > workingTime) {
                finishTime = arrival + time;
            } else {
                finishTime += time;
            }
            waitingTimeSum += finishTime - arrival;
            workingTime = finishTime;
        }  
        return waitingTimeSum / customers.Length;    
    }
}

