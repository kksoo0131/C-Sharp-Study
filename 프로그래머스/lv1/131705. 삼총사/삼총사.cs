using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public List <int> answer;
    public int[] number;
    
    public int solution(int[] number) {
        answer = new List<int>();
        this.number = number;
        DFS(0,0,0);
        return answer.Where(x => x==0).Count() ;
    }
    
    public void DFS(int start, int depth, int sum){
        
        if (depth ==3){ answer.Add(sum); return;}
        
        for (int i= start; i<number.Length; i++){
            sum += number[i];
            DFS(i+1, depth+1, sum);
            sum -= number[i];
            }    
        
        
    }
}