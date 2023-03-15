using System;
using System.Collections.Generic;
class Solution
{
    public int solution(int n, int a, int b)
    {
        int round =1;
        int match =2;           
        
        while (true){
            //그룹을 나눠서 확인. 1~ 16 17 ~32
            for (int i = 1; i <= n; i+=match){
                bool checkA = false;
                bool checkB = false;
                
                // 그룹에 A,B둘다있다면 리턴
                for (int j =0; j < match ; j++){
                    if (i + j == a)
                        checkA = true;
                    
                    if (i + j == b)
                        checkB = true;
                    
                    if (checkA == true && checkB == true)
                        return round;    
                }
                
                
            }
            
            // 다음 라운드로.
            match *=2;
            round++;
                
        }

        return round;
    }
}