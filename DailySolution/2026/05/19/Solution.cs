namespace LeetCodeDaily20260519;

public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        int current1 = 0;
        int current2 = 0;

        int maxLength = Math.Max(nums1.Length, nums2.Length);
        while(current1 < maxLength && current2 < maxLength) {
            if(nums1[current1] == nums2[current2]) {
                return nums1[current1];
            }
            if(nums1[current1] < nums2[current2]) {
                current1++;
            } else {
                current2++;
            }
        }
        return -1;
    }
}