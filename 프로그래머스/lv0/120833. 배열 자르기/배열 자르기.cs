using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int[] answer = new int[num2-num1+1];
            
        for (int i =0; num1 + i<= num2; i++)
            answer[i] = numbers[num1 + i];
        
        return answer;
    }
}