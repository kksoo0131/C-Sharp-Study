using System;

public class Solution {
    public int solution(int[] numbers) {
        int length = numbers.Length;
        Array.Sort(numbers);
        return numbers[length-1] * numbers[length-2];
    }
}