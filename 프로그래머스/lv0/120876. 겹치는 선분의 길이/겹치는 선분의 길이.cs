using System;
using System.Linq;

public class Solution {
    static int answer =0;
    public int solution(int[,] lines) {
         
        int[] first_overlap1 = Overlap(lines[0,0],lines[0,1],lines[1,0], lines[1,1]);
        int[] first_overlap2 = Overlap(lines[0,0],lines[0,1],lines[2,0], lines[2,1]);
        int[] first_overlap3 = Overlap(lines[1,0],lines[1,1],lines[2,0], lines[2,1]);        
        
        answer += first_overlap1[1] - first_overlap1[0];
        answer += first_overlap2[1] - first_overlap2[0];
        answer += first_overlap3[1] - first_overlap3[0];
        
        int[] second_overlap1 =
            Overlap(first_overlap1[0], first_overlap1[1],first_overlap2[0], first_overlap2[1]);
        int[] second_overlap2 =
            Overlap(first_overlap1[0], first_overlap1[1],first_overlap3[0],first_overlap3[1]);
        int[] second_overlap3 =
            Overlap(first_overlap2[0], first_overlap2[1],first_overlap3[0],first_overlap3[1]);
        
    
        answer -= second_overlap2[1] - second_overlap2[0];
        answer -= second_overlap3[1] - second_overlap3[0];
        
        Console.WriteLine();
        
        

        
       
     
        // 두 선분이 겹치는 좌표를 확인
        // 1,2  2,3  1,3 모두 확인을 하고
        // 한번 더 겹치는 좌표를 확인 해서 2.번에서 뺴준다.
        
            
        
        return answer;
    }
    
    static int[] Overlap(int a0, int a1, int b0, int b1){
        if (Math.Max(a0,b0) > Math.Min(a1,b1))
            return new int[]{0,0};           
        return new int[]{Math.Max(a0,b0), Math.Min(a1,b1)};
        
    }
}