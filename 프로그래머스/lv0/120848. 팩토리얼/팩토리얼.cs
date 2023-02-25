using System;

public class Solution {
    public int solution(int n) {
        int answer = 1;
        long a = 1;
        
        while (a <=n){
            a  *= ++answer;
        }
        return answer-1;            
    
    }
}