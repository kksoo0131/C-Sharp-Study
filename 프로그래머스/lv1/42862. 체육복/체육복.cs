using System;
using System.Linq;

public class Solution {
   // 1. 모든 학생들의 체육복 list를 만들자
   // 체육복의 개수가 student에 저장
   // 학생의 번호와 인덱스 번호를 맞춰주기 위해서 n+1의 배열 생성
    
    
    // 생각 해야되는 부분?
    // 만약 1,2,3 세 학생이 있을때
    // 2가 여분의 체육복이 이 있다면 1,3중에 한명한테 빌려줄 수 있다.
    
    // 그런데 1,2,3,4,5 5명의 학생이 있을떄 {0,2,1,2,0} 이라면
    // 1 1 1 2 0 이거나 (무조건 앞의 사람한테 빌려줌)
    // 0 2 1 1 1 이된다.(무조건 뒤의 사람한테 빌려줌)
    // 1 1 1 1 1 (내가 원하는 답)
    // 그러면 둘다 실행하면 되나?
    
    // 앞 -> 뒤 , 뒤 -> 앞의 순서에 따라서 결과값이 달라질 수 있나..?
    
    // student
    
 
    public int solution(int n, int[] lost, int[] reserve) {
        int answer1 = 0;
        int answer2 = 0;
        
        int[] student1 = Enumerable.Repeat(1,n+1).ToArray();
        int[] student2 = new int[n+1];
        int count =0;
        student1[0] = 0;
        
        foreach(int lostStudent in lost)
        {
            student1[lostStudent]--;
        }
        
        foreach(int reserveStudent in reserve)
        {
            student1[reserveStudent]++;
        }
        
        student1.CopyTo(student2,0);
        
        for (int i=1; i< n; i++)
        {
            if(student1[i] > 1 && student1[i+1] == 0){
                student1[i]--;
                student1[i+1]++;
            }
        }
        
        for (int i=n; i>1; i--)
        {
            if(student1[i] > 1 && student1[i-1] == 0){
                student1[i]--;
                student1[i-1]++;
            }
            
            if(student2[i] > 1 && student2[i-1] == 0){
                student2[i]--;
                student2[i-1]++;
            }
        }
        
        for (int i=1; i< n; i++)
        {
            if(student2[i] > 1 && student2[i+1] == 0){
                student2[i]--;
                student2[i+1]++;
            }
        }
        
        foreach(int i in student1)
        {
            answer1 += i > 0 ? 1 : 0;
        }
        
         foreach(int i in student2)
        {
            answer2 += i > 0 ? 1 : 0;
        }
        
        return answer1 > answer2 ? answer1 : answer2;
        
       
    }
}