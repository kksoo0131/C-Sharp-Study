using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        // 빈칸. 파일이있는칸 #
        //최소한의 드래그로 파일을 모두 선택해서 삭제하려고한다.
        // 결국 파일이 있는 칸의 최소 x,y좌표와 최대 x,y좌표를 통해서
        // maxY - minY + maxX - minX
        int[] answer = new int[] {};
        
        int maxX = int.MinValue;
        int maxY = int.MinValue;
        int minX = int.MaxValue;
        int minY = int.MaxValue;
    
        for(int i =0; i< wallpaper.Length; i++)
        {
            for (int j =0; j<wallpaper[0].Length; j++)
            {
                if(wallpaper[i][j] == '#')
                {
                    minX = Math.Min(minX, i);
                    minY = Math.Min(minY,j);
                    
                    maxX = Math.Max(maxX, i);
                    maxY = Math.Max(maxY, j);
                }
            }
        }
        return new int[]{minX,minY, maxX+1,maxY+1};
        // max만 +1인 이유는 나는 각 칸에는 시작점과 끝점이 존재하고
        // min은 시작점이지만 max는 끝점임 나는 시작점을 구했기 때문에 max에 +1을해서 끝점을 구함
    }
}