namespace LeetCodeDaily20260602;
public class Solution {
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        int earliestFinishTime = int.MaxValue;
        for (int i = 0; i < landStartTime.Length; i++) {
            int landFinishTime = landStartTime[i] + landDuration[i];
            for (int j = 0; j < waterStartTime.Length; j++) {
                
            }
        }

        return earliestFinishTime;
    }
}