using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array) {
        Dictionary<int, int> dic = new Dictionary<int,int>();
        int[] answer = {0,0};
        bool isDuplicate = false;
        foreach (int i in array)
        {
            
            if (dic.ContainsKey(i))
            {
                dic[i]++;   
            } 
            else
            {
                dic.Add(i,1);
            }
        }
        
        foreach(int key in dic.Keys){
            if (dic[key] > answer[1]){
                answer[0] = key;
                answer[1] = dic[key];
                isDuplicate = false;
            }
            else if ( dic[key] == answer[1]){
                isDuplicate = true;
            }
            
            
        }
        return isDuplicate ? -1 : answer[0];
    }
}