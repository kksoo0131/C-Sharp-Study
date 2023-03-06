using System;

public class Solution {
    public int[] numbers;
    public int answer;  
    public int target;
    public int solution(int[] numbers, int target) {
        this.numbers = numbers;
        this.answer =0;
        this.target = target;
        DFS (0,0);
        return answer;
    }
    
    public void DFS(int start, int sum){
        
        if (start == numbers.Length){
            if(sum == target)
                answer +=1;
            return;
        }
                
        DFS(start +1, sum + numbers[start]);
        DFS(start +1, sum - numbers[start]);
        
    }
}