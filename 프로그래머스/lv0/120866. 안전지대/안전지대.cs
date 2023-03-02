using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        int n = (int)Math.Sqrt(board.Length);
        
        
        for(int i =0; i < n; i++){
            for(int j=0; j< n; j++){
                if (board [j,i] == 1 ){   
                    answer +=1;
                    if (i-1 >=0 && board [j,i-1] == 0 ){
                        board [j,i-1] = 2;
                        answer +=1;
                    }
                    
                    if (i+1 <n &&board [j,i+1] == 0){
                        board [j,i+1] = 2;
                        answer +=1;
                    }
                    
                    if (j-1 >=0 &&board [j-1,i] == 0){
                        board [j-1,i] = 2;
                        answer +=1;
                    }
                    if (j-1 >=0 && i-1>=0 && board [j-1,i-1] == 0){
                        board [j-1,i-1] = 2;
                        answer +=1;
                    }
                    
                    if (j-1 >=0 && i+1 <n &&board [j-1,i+1] == 0){
                        board [j-1,i+1] = 2;
                        answer +=1;
                    }
                    
                    if (j+1 < n &&board [j+1,i] == 0 ){
                        board [j+1,i] = 2;
                        answer +=1;
                    }
                    if (j+1 < n && i-1 >=0 &&board [j+1,i-1] == 0){
                        board [j+1,i-1] = 2;
                        answer +=1;
                    }
                    if (j+1 < n && i+1<n &&board [j+1,i+1] == 0 ){
                        board [j+1,i+1] = 2;
                        answer +=1;
                    }
                    
                        
                }       
            }
        }
        

        return n*n - answer;
    }
    

}