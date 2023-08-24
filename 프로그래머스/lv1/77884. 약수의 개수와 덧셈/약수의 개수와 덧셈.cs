using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        
        while(left <= right){
            answer += func(left++);
        }
        
        return answer;
    }
    
    public int func(int num){
        int count =0;
        
        for (int i = 1; i<= num; i++){
            count += num % i == 0 ? 1 : 0;
        }

        return count % 2 == 0 ? num : num * -1 ;
    }
}