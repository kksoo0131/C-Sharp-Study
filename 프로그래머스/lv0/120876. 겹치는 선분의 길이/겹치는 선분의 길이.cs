using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] lines) {
        // 길이가 1이상인것만 취급해야하고
        //중첩되는걸 한번만 잡아내야되는 문제.
        List <int[]> listline = new List<int[]>();
        List <int[]> answer = new List<int[]>();
        
        for (int i =0; i<lines.GetLength(0); i++){
            
            int max = Math.Max(lines[i,0],lines[i,1]);
            int min = Math.Min(lines[i,0],lines[i,1]);
            
            for(int j =min; j<max; j++){
                if (listline.Exists (x => x[0] ==j && x[1] == j+1)){
                    if (!answer.Exists (x => x[0] ==j && x[1] == j+1)){
                        answer.Add(new int[] {j,j+1});
                    }
                }
                else{
                    listline.Add(new int[] {j,j+1});
                }
                    
            }
            
        }
        return answer.Count();
    }
}