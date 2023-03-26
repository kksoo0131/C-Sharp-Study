using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        
        foreach (int i in tangerine){
            if (dic.ContainsKey(i) == false)
                dic.Add(i, 1);
            else
                dic[i] +=1;
        }
        
       
        List<int> list = dic.Select(x => x.Value).ToList();
        list.Sort();
        
        while(k>0){
            k -= list[list.Count-1];
            list.Remove(list[list.Count-1]);
            answer++;
        }
        

        return answer;
    }
}