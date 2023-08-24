using System;

public class Solution {
    public int solution(int[] number) {
        // 배열에서 3개를 골라서 합이 0이되는 경우의수를 구해라
        int answer = 0;
        
        for(int i =0; i< number.Length; i++){
            for(int j =i+1; j< number.Length; j++){
                for(int k = j+1 ; k < number.Length; k++){
                    answer += number[i] + number[j] + number[k] == 0 ? 1 : 0;
                }
                
            }
        }
        
        return answer;
    }
}