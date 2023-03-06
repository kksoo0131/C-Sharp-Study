using System;

public class Solution {
    public int[] numbers; 
    public int target;
    
    public int solution(int[] numbers, int target) {
        this.numbers = numbers;
        this.target = target;
       
        return  DFS (0,0);
    }
    
    public int DFS(int start, int sum){
        
        if (start == numbers.Length){
            if(sum == target)
                return 1;
            return 0;
        }
        else
            return DFS(start +1, sum + numbers[start]) + DFS(start +1, sum - numbers[start]);
                
    }
}