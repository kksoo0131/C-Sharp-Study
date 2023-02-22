using System;

public class Solution {
    public int solution(int[] sides) {
        Array.Sort(sides);
        int answer = sides[2] < sides[1] + sides[0] ? 1 : 2 ;    
        return answer;
    }
}