using System;

public class Solution {
    // n편의 논문중 h번 이상 인용된 논문이 h편 이상이면 H-Index 는 h
    
    // h보다 크거나 같은게 h개 이상이라면
    
    // 일단은 citations를 정렬한다.
    
    // 그러면 배열의 index는 이 논문보다 적게 인용된 나머지 논문의 개수가 된다.
    
    // length - index는 이 논문 이상으로 인용된 논문의 개수가 된다( 이 논문도 포함임)
    
    // 만약 citations 배열의 길이가
    
    // 요소의 최솟값보다 짧다면 citations의 길이가 answer가 된다. -> break추가
    
    public int solution(int[] citations) 
    {
        Array.Sort(citations);
        
        int answer = 0;
        
        for (int i =0; i< citations.Length; i++)
        {
            
            if (citations[i] <= citations.Length -i)
            {
                if (i <= citations[i])
                {
                    answer = citations[i];    
                }
                
            }
            else
            {
                answer = citations.Length -i;
                break;
            }
        }
        
        return answer;
    }
}