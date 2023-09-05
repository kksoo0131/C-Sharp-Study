using System;

public class Solution {
    // 노랑색 격자의 수는? 가로 -2 * 세로 -2
    // 갈색 격자의 수는 가로 * 세로 - 노란색 격자
    
    // 갈색 격자 + 노란색 격자 = 가로 * 세로
    
    // 가로길이가 더길다.
    
    public int[] solution(int brown, int yellow) 
    {

        int total = brown + yellow;
        int sqrt = (int)Math.Sqrt(total);
        
        
        
        while(sqrt > 1)
        {
            if (total % sqrt == 0)
            {
                int width = total/sqrt;
                int height = sqrt;
                
                if (brown == (width - 2 + height -2) * 2 + 4)
                {
                    // 조합이 브라운 갯수를 만족하는지 확인
                    break;
                }
            }
            
            sqrt--;   
               
        }
        
        
        return new int[] {total/sqrt , sqrt};
    }
}

/* 테스트케이스 4,6,7 실패
public class Solution {
    // 노랑색 격자의 수는? 가로 -2 * 세로 -2
    // 갈색 격자의 수는 가로 * 세로 - 노란색 격자
    
    // 갈색 격자 + 노란색 격자 = 가로 * 세로
    
    // 가로길이가 더길다.
    
    public int[] solution(int brown, int yellow) 
    {
        int total = brown + yellow;
        
        int sqrt = (int)Math.Sqrt(total);
        
        
        while(total % sqrt != 0)
        {
            sqrt--;   
               
        }
        
        
        return new int[] {total/sqrt , sqrt};
    }
}
*/