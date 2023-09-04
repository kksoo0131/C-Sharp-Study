using System;
using System.Collections.Generic;

public class Solution 
{   
    
    
    // result의 신고메일은 신고 한사람이 받는거임
    
    // Dictionary를 돌면서 count가 k보다 크다면?
    
    // hashset 안의 사람들에게 결과메일을 +1 해줘야됨
    public int[] solution(string[] id_list, string[] report, int k) 
    {
        Dictionary<string,HashSet<string>> hashSetDic = new Dictionary<string,HashSet<string>>();
        Dictionary<string, int> result = new Dictionary<string, int>();
        
        int[] answer = new int[id_list.Length];
        
        foreach(string id in id_list)
        {
            hashSetDic.Add(id, new HashSet<string>());
            result.Add(id,0);
        }
        
        foreach(string str in report)
        {
            string[] temp = str.Split(" ");
            hashSetDic[temp[1]].Add(temp[0]);
        }
        
        foreach(string id in id_list)
        {
            if (hashSetDic[id].Count >= k)
            {
                foreach(string id2 in hashSetDic[id])
                {
                    result[id2]++;
                }
            };
        }
        
        
        for (int i=0; i< id_list.Length; i++)
        {
            answer[i] = result[id_list[i]];
        }
        
        return answer;
    }
}