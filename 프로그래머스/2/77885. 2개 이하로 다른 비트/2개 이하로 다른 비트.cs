using System;
using System.Collections.Generic;

public class Solution {
    // 입력받은 long 값을 이진수로 만들면서 스택에 넣습니다.
    // 만약 이번 자릿수가 0이라면 반복문을 종료하고 스택의 Count (이번 자릿수)를 1로 변경합니다
    // 선택된 자리의 바로 뒤에있는 1을 0으로 변경합니다 스택의 Count-1
    // 만약 stack의 count가 0이라면 뒤에 1이 없으므로 바꾸어주지 않아도됩니다. (1개만 변경)
    
    // 10, 11 계속 실패해서 질문하기 참고
    // 비트연산시 피연산자는 32비트 정수로 변환되며 일련의 비트(0과 1)로 표현됩니다. 
    // 32비트 이상인 숫자는 최상위 비트가 삭제됩니다. 예를 들어 32비트 이상인 다음 정수는 32비트 정수로 변환됩니다
    
    /*
        for(int i=0; i < 50; i++)
        {
            Console.WriteLine( 1 << i);    
        }
        를 돌려보면 확인이 가능하다.
        
        30까지는 (31자리) 정상적으로 작동
        31은 (32자리) 음수로변함
    */
    
   public long[] solution(long[] numbers) 
   {
        long[] answer = new long[numbers.Length];
       
       for(int i =0; i< numbers.Length; i++)
       {
           answer[i] = FindBinary(numbers[i]);
       }
       
       return answer;
        
    }
    
    public long FindBinary(long number)
    {   
        long thisNumber = number;
        Stack<long> stack = new Stack<long>();
                
        while(thisNumber != 0 && thisNumber % 2 == 1)
        {
            stack.Push(thisNumber % 2);
            thisNumber /= 2;
        }
        
        if (stack.Count > 31)
        {
            int num = stack.Count -30;
            long temp = (1 << 30);
            long temp2 = (1 << num);
            long addNum = temp * temp2 / 2;
 
            return number + addNum;
        }
        else
        {
            if (stack.Count == 0)
            {
                return number + (1 << stack.Count);    
            }
            else
            {
                return number + (1 << stack.Count) / 2;
            }
        }
        
 
        
        
    }
    
}
