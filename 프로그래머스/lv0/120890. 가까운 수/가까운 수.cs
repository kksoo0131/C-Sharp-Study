using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int check = 101;
        for (int i = 0; i < array.Length; i++){
            if(array[i] >= n){
                if(array[i] - n < check){
                    check = array[i] - n;
                    answer = array[i];    
                }
                
            }
            else{
                if(n- array[i] <= check){
                    check = n - array[i];
                    answer = array[i];
                }
            }
            
                
                
        }
        return answer;
    }
}