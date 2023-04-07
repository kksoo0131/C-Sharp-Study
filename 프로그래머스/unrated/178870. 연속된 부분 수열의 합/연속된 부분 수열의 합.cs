using System.Collections.Generic;
using System.Linq;
using System;

public class Solution {
    
    public int[] solution(int[] sequence, int k) {
        int n = sequence.Length;
        int[] partialSums = new int[n+1];
        partialSums[0] = 0;
        for (int i =1 ; i <= n; i++){
            partialSums[i] = partialSums[i-1] + sequence[i-1];
            // partialSums[1] ~ partialSums[n]는 sequence[0] ~ sequence[n-1] 까지의 합이된다.
        }
        
        int left =0, right =0, minLen = n+1, start= -1, end = -1;
        
        while(right < n){
            
            int sum = partialSums[right+1] - partialSums[left]; 
            // partialSums[1] - partialSums[0] = sequence[0]
            // partialSums[n] - partialSums[n-1] = sequence[n-1] (sequece는 길이가 n이고 partialSums는 길이가 n+1임)
            if(sum <k)
                right++;
            else if(sum > k)
                left ++;
            else{
                // 제일 짧은 것을 찾기위해서
                if (right - left + 1 < minLen){
                    minLen = right - left +1;
                    start = left;
                    end = right;
                }
                left++;
            }
            
        }

        return new int[] {start, end};
        
    }      
}
