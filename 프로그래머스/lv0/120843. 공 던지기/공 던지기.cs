using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        return numbers[((k-1) * 2) % numbers.Length];
    }
}