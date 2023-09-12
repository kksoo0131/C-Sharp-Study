using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) 
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        int answer = 1;
        
        for(int i =0; i< clothes.GetLength(0); i++)
        {
            if (!dic.ContainsKey(clothes[i,1]))
            {
                dic.Add(clothes[i,1],0);
            }
            dic[clothes[i,1]]++;
        }
        
        
        // dic에는 옷이 종류별로 있음
        
        // 1. 각각 옷의 갯수를 전부더함
        // 2. 옷의 조합 각각의 곱을 전부 곱합 ( 종류가 2개이상일때만임)
        
        
        
        foreach(KeyValuePair<string,int> kvp in dic)
        {
            answer *= (kvp.Value + 1);
        }
        
        
        
        
        return answer -1;
    }
}