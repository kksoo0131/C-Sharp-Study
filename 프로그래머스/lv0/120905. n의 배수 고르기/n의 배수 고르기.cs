using System;

public class Solution {
    public int[] solution(int n, int[] numlist) {
    
        return Array.FindAll(numlist, x => x%n ==0);
    }
}