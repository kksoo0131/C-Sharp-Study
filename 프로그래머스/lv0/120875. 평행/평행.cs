using System;

public class Solution {
    public int solution(int[,] dot) {
    
    
        if((float)Math.Abs(dot [0,1] - dot[1,1]) / (float)Math.Abs(dot [0,0] - dot[1,0]) 
           == (float)Math.Abs(dot[2,1] - dot[3,1]) / (float)Math.Abs(dot[2,0] - dot[3,0]))
            return 1;
        
        if((float)Math.Abs(dot [0,1] - dot[2,1]) / (float)Math.Abs(dot [0,0] - dot[2,0]) 
           == (float)Math.Abs(dot[1,1] - dot[3,1]) / (float)Math.Abs(dot[1,0] - dot[3,0]))
            return 1;
         
        if((float)Math.Abs(dot [0,1] - dot[3,1]) / (float)Math.Abs(dot [0,0] - dot[3,0]) 
           == (float)Math.Abs(dot[1,1] - dot[2,1]) / (float)Math.Abs(dot[1,0] - dot[2,0]))
            return 1;
        
        return 0;            
    }
}