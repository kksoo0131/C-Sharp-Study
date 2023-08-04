using System;

public class Solution {
    
    public int solution(int[] array, int n) {
        /*
        int answer = 0;
        foreach(int i in array){
            answer += (i == n ? 1 : 0);
        }
        return answer;
        */
        
        return Array.FindAll(array, x => x == n).Length;
    }
   
}