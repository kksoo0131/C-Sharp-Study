using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        for(int j =1; j<4; j++){
            if ((dots[0,0] != dots[j,0]) && (dots[0,1] != dots[j,1])) 
               answer =  Math.Abs(dots [0,0] - dots [j,0]) * Math.Abs(dots[0,1] - dots [j,1]);
        }
        return answer;
    }

    
}