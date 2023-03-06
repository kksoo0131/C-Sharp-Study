using System;

public class Solution {
    int [,] computers;
    int answer;
    bool[] check;
    
    public int solution(int n, int[,] computers) {
        this.computers = computers;        
        answer = 0;
        check = new bool[computers.GetLength(0)]; 
        
        for (int i =0; i < computers.GetLength(0); i++){
            //이미 체크가 되있으면 볼필요없음
            if(!check[i])
                DFS (i, 0);    
        }     
        
        return answer;
    }
    
    public void DFS(int start,int length){
        
        if (length == 0)
            answer +=1;
        
        //  한 네트워크에 속한 모든 컴퓨터를 탐색
        check[start] = true;
        
        for (int i = 0; i < computers.GetLength(0); i++){
            // 연결 확인
            if (!check[i] && computers[start,i] == 1)
                DFS(i, length+1); 
        }
        
    

    }
    
}