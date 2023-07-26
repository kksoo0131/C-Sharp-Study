using System;

public class Solution {
    public int solution(int angle) {
        int answer = angle / 90;
        int R = angle % 90;
        
        if (answer == 2)
            return 4;
        else if (answer ==1 && R != 0)
            return 3;
        else if (answer == 1)
            return 2;
        else
            return 1;

    }
}