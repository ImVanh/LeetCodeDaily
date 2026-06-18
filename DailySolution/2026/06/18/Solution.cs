namespace LeetCodeDaily20260618;

public class Solution {
    public double AngleClock(int hour, int minutes) {
        double hourAngle = (hour % 12 + minutes / 60.0) * 30;
        double minuteAngle = minutes * 6;
        double angle = Math.Abs(hourAngle - minuteAngle);
        return Math.Min(angle, 360 - angle);
    }
}