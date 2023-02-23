using System;

public class Solution {
    public int solution(int[] numbers) {
        Array.Sort(numbers);
        
        int minus = numbers[0] * numbers[1];
        int plus = numbers[numbers.Length-2] * numbers[numbers.Length-1];    
        return minus > plus ?minus : plus;
    }
}