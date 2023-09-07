using System;
using System.Collections.Generic;

public class Solution {
    // 배열에서 n개의 수를 골라서 새로운 수를 만든다.
    
    // 일단 수를 고르는 경우의수는 1~n까지임
    
    // 시작점부터 끝까지 하나씩 더해보면서 배열에 저장
    
    
    public int solution(int[] elements) 
    {
        HashSet<int> hashSet = new HashSet<int>();
        
        for (int i =0; i< elements.Length; i++)
        {
            int temp = 0;
            for(int j=i; j< elements.Length; j++)
            {
                temp += elements[j];
                hashSet.Add(temp);
            }
            
            for(int k=0; k < i; k++)
            {
                temp += elements[k];
                hashSet.Add(temp);
            }
        }
        
        
        
        return hashSet.Count;
    }
    
}