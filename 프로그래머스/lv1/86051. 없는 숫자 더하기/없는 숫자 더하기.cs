using System;

public class Solution {
    public int solution(int[] numbers) {
        
        int max = 0;
        int sum = 0;
        for (int i= 0; i<=9; i++){
            max += i;
        }
        
        foreach(int i in numbers){
            sum += i;
        }
        
        return max-sum;
    }
}