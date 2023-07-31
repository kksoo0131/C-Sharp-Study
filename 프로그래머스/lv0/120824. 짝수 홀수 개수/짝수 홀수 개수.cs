using System;

public class Solution {
    public int[] solution(int[] num_list) 
    {
        int[] answer = new int[] {0,0};
        
        foreach(int n in num_list)
        {
            answer[n%2]++;
        }
        return answer;
    }
}