using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string[] park, string[] routes) 
    {
        int[] start = new int[2];
        Dictionary<string, int[]> dirDic = new Dictionary<string, int[]>();
        
        dirDic.Add("N", new int[]{-1,0});
        dirDic.Add("S", new int[]{1,0});
        dirDic.Add("W", new int[]{0,-1});
        dirDic.Add("E", new int[]{0,1});

        
        for (int i =0; i<park.Length; i++)
        {
            for (int j = 0; j < park[i].Length ; j++)
            {
                if(park[i][j] == 'S'){
                    start[0]= i;
                    start[1]= j;
                }
            }    
        }

        
        foreach(string route in routes)
        {
            int[] dir = dirDic[route.Substring(0,1)];
            int move = int.Parse(route.Substring(2,1));
            bool isMove = true;
            int[] temp = new int[2];
            Array.Copy(start,temp,temp.Length);
            
            for(int i =0; i< move; i++)
            {
                int nextY = temp[0] + dir[0];
                if ( nextY < 0 || nextY >= park.Length)
                {
                    isMove = false;
                    // 0보다 크고 park.Length 보단 작아야함
                }
                
                int nextX = temp[1] + dir[1];
                if (nextX < 0 || nextX >= park[0].Length)
                {
                    isMove = false;
                }
                
                if (isMove)
                {
                    if (park[nextY][nextX] == 'X'){
                        isMove = false;
                    }
                }
                
                temp[0]= nextY;
                temp[1]= nextX;
                
            }
            
            if (isMove)
            {
                start = temp;       
            }

            //주어진방향으로 이동하는 도중에 장애물이 있는지
            //끝까지 이동할때 공원을 벗어나는지 확인
        }
        

        return start;
    }
}