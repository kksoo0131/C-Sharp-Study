using System;

public class Solution {
    public int solution(int[] sides) {     
        return Math.Min(sides[0], sides[1]) * 2 -1;
    }
}