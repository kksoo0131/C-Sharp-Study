using System;

public class Solution {
    public int solution(int angle) {
        int answer = 1 + angle / 90 + (angle > 90 ? 1 : 0);

        return answer;
    }
}