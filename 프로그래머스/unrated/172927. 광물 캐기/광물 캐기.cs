using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    string[] minerals;
    public int solution(int[] picks, string[] minerals) {
        int answer = 0;
        this.minerals = minerals;
        List<int[]> list = new List<int[]>();
        
        if ((picks[0] + picks[1] + picks[2]) * 5  < minerals.Length){
           minerals = new ArraySegment<string>(minerals, 0, (picks[0] + picks[1] + picks[2]) * 5 ).ToArray();
        }
        
        for (int i = 0; i < minerals.Length /5; i++){
            list.Add(Mining(i*5));
        }
        list.Add(Mining(minerals.Length /5 *5,minerals.Length % 5));
        
        list = list.OrderBy(x => x[2]).ToList();
        list.Reverse();

       
        while(list.Count() >0 &&picks[0] > 0)
        {
            answer += list[0][0];
            list.RemoveAt(0);
            picks[0] -=1;
        }
        
        while(list.Count() >0 &&picks[1] > 0)
        {
            answer += list[0][1];
            list.RemoveAt(0);
            picks[1] -=1;
        }
        
        while(list.Count() >0 &&picks[2] > 0){
            answer += list[0][2];
            list.RemoveAt(0);
            picks[2] -=1;
        }
   
        
        return answer;
}
    
    
    int[] Mining(int start,int repeat = 5){
        int[] temp = new int[]{repeat,0,0};
        for (int j = 0; j<repeat; j++){
            switch(minerals[start + j]){
                case "diamond":
                    temp[1] += 5;
                    temp[2] += 25;
                    break;
                case "iron":
                    temp[1] += 1;
                    temp[2] += 5;
                    break;
                case "stone":
                    temp[1] += 1;
                    temp[2] += 1;
                    break;    
            }
        }
        return temp;
    }
}