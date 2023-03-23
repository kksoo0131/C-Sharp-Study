using System;

public class Solution {
    public int solution(int[] citations) {
        Array.Sort(citations);
        int answer = 0; // 0 1 3 5 6
        for (int i = 0; i < 10000; i++){
            // 배열안에서 i 보다 큰것의 갯수가 i보다 많다면
           for(int j =0; j< citations.Length; j++)
           {
               if (citations[j] >= i && citations.Length -j >= i )
               {
                   answer = i;
                   break;
               }
                    
           }
            // answer == i가 아니면 틀렸음 return
            if (answer != i)
                break;
        }
        
    
        return answer;
    }
}