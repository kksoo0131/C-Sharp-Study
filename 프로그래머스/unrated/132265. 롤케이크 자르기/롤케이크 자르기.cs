using System;
using System.Collections.Generic;

public class Solution {
    // 토핑의 가짓수를 공평하게 할 수 있는 방법의 갯수를 찾아라.
    
    int[] topping;
    public int solution(int[] topping) 
    {
        this.topping = topping;
        Dictionary<int,int> left = new Dictionary<int,int>();
        Dictionary<int,int> right = MakeToppingDic();
        int answer = 0;
        
        foreach(int i in topping)
        {
            right[i]--;
            
            if (right[i] <= 0)
            {
                right.Remove(i);
            }
            
            if(left.ContainsKey(i))
            {
                left[i]++;
            }
            else
            {
                left.Add(i,1);
            }
            
            
            answer += right.Keys.Count == left.Keys.Count ? 1 : 0;
        }
        
        
        
        return answer;
    }
    
    public Dictionary<int,int> MakeToppingDic()
    {
        Dictionary<int,int> toppingDic = new Dictionary<int,int>();
        
        foreach(int i in topping)
        {
            if (toppingDic.ContainsKey(i))
            {
                toppingDic[i]++;    
            }
            else
            {
                toppingDic.Add(i, 1);    
            }
            
        }
        
        return toppingDic;     
    }
}