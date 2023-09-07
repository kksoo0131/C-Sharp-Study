using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    // 귤을 크기별로 분류하고
    // 한 상자에 귤의 종류가 최소가 되도록 담는다
    
    // 배열에 index == 귤의크기 value == 갯수로 배열을 만든다.
    // 배열을 정렬해서 종류가 많은 귤부터 상자에 담는다.
    
    // 배열로 만들면 실행시간이 너무 오래걸린다. -> 배열의 최대 길이가 10,000,000 되기 떄문
    // 테스트는 통과하지만 대충 2000ms까지 걸림
    
    // 딕셔너리를 정렬하기 위해서 List로 만든다. -> 딕셔너리에는 순서가 없어서
    // 테스트 최대 40ms대
    
    public int solution(int k, int[] tangerine) 
    {
        int max = tangerine.Max();
        Dictionary<int,int> classify = new Dictionary<int,int>();
        int answer =0;
        foreach(int i in tangerine)
        {
            if(classify.ContainsKey(i))
            {
                classify[i]++;
            }
            else
            {
                classify.Add(i,1);
            }
            
        }
        
        List<KeyValuePair<int,int>> classifyList = classify.ToList();
        classifyList.Sort((x,y) => y.Value.CompareTo(x.Value));
        // (x,y)에서 x.CompareTo(y) 는 오름차순 y.CompareTo(x)는 내림차순이다.
        
        for (int i = 0; i< classifyList.Count; i++)
        {
            k -= classifyList[i].Value;
            answer++;
             if(k <=0)
            {
                break;
            }
        }
        
       
        
        return answer;
    }
}