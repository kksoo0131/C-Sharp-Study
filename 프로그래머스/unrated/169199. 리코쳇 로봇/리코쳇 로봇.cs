using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] board) {
        int answer = -1;
        int width = board[0].Length;
        int height = board.Length;
        int[,] dir = new int[,] { {-1,0}, {1,0},{0,-1},{0,1}};
        int[] start = FindStart(board);
        
        Queue<int[]> queue = new Queue<int[]>();
        List<int[]> list = new List<int[]>();
        
        for(int i =0; i< height; i++){
            list.Add(Enumerable.Repeat(0, width).ToArray());
        }
           
        queue.Enqueue(start);
        list[start[0]][start[1]] = 1;
        
        while(queue.Count > 0 ){
            int[] position = queue.Dequeue();
            
            if (board[position[0]][position[1]] == 'G'){
                answer = list[position[0]][ position[1]]-1;
                break;
            }

            
            for (int i =0; i< dir.GetLength(0); i++){
                int[] next = new int[] { position[0],position[1]};
                
                while(true){
                    next[0] += dir[i,0];
                    next[1] += dir[i,1];    
                    
                    if ( next[0] <0 ||  next[0] > height-1){
                        next[0] -= dir[i,0];
                        break;    
                    }
                        
                    if (next[1] <0 || next[1] > width-1){
                        next[1] -= dir[i,1];
                        break;
                    }
                        
                    if(board[next[0]][next[1]] == 'D'){
                        next[0] -= dir[i,0];
                        next[1] -= dir[i,1];
                        break;
                    }
                        
                }
                
                if (list[next[0]][next[1]] != 0)
                    continue;
                
                queue.Enqueue(next);
                list[next[0]][next[1]] = list[position[0]][position[1]] + 1;
            }
                
            
        }
        
        return answer ;
    }

    
    int[] FindStart(string[] board){
        int[] start = new int[]{0,0};
        foreach(string s in board){
            if (s.Contains("R")){
                start[0] = Array.IndexOf(board, s);
                start[1] = board[start[0]].IndexOf('R');
                return start;
            }
        }
        Console.WriteLine("시작위치를 찾지 못했습니다");
        return start;
    }
}