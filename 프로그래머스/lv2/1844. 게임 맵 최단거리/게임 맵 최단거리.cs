using System;
using System.Collections.Generic;

class Solution {

    public int solution(int[,] maps) {
        return bfs(maps, new int[] {0,0});
    }
    
    int bfs (int[,] maps, int[] start){
        
        Queue <int[]> queue = new Queue<int[]>();
        queue.Enqueue(start);
        
        int[] dx = {0,1,-1,0};
        int[] dy = {1,0,0,-1};
        
        while(queue.Count > 0){
           
            // 이미 도착했다면 return
            if(maps[maps.GetLength(0)-1, maps.GetLength(1)-1] != 1)
                return maps[maps.GetLength(0)-1, maps.GetLength(1)-1];
            
            start = queue.Dequeue();
            
            for (int i =0; i< 4; i++){
                int nx = start[0] + dx[i];
                int ny = start[1] + dy[i];
                
                if (nx > maps.GetLength(0)-1 || nx < 0 || ny > maps.GetLength(1)-1 || ny < 0)
                    continue;
                
                if (maps[nx,ny] == 1) {
                    maps[nx,ny] = maps[start[0],start[1]] + 1;
                    queue.Enqueue(new int[] {nx,ny});
                }              
            } 
            
        }
    
            return -1;
    }
}