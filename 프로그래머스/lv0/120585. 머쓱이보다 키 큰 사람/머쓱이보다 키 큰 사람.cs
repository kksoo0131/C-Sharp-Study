using System;

public class Solution {
    public int solution(int[] array, int height) {
        int answer = 0;
        
        foreach(int i in array){
            answer += i > height ? 1 : 0;
        }
        return answer;
    }
}