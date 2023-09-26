using System;
using System.Collections.Generic;

public class Solution {
    // 2중 for문을 돌릴때 중복되는 부분이 어디지?
    
    // 0 -> 1~ n까지 0과비교
    // 1 -> 2 ~n 까지 1과 비교
    
    // 큰수를 찾았다면 멈추고 다음으로 넘어가면되고
    // 만약그런데 0과1이 같은수라면? 0과 1을 한번에 같이 찾아주면됨
    
    // 개선은 성공 시간초과 1개 발생
    
    // 더 개선할 방법? 예를들어 케이스 2에서 5, 3, 6 같은 경우에
    
    // 5보다 작은 3도 함께 6이 된다. -> 6 6 -1
    
    // 그런데 만약 5,3,4,6 이였다면? > 6 4 6 -1 이됨
    
    
    // 그렇다면? 스택을 이용?? 스택에는 인덱스들이들어가야된다.
    
    // 처음에 스택에 수를 넣고 배열을 순회하면서
    
    // 1. 스택의 Peek보다 작거나 같은수라면? stack에넣는다.
    // 2. 스택의 Peek보다 큰 수라면? 해당 answer에 이번수를 넣고 Pop을한다.
    
    public int[] solution(int[] numbers) 
    {
        int[] answer = new int[numbers.Length];
        Stack<int> numberStack = new Stack<int>();
        
        for(int i=0; i< numbers.Length; i++ )
        {
            if (numberStack.Count ==0)
            {
                numberStack.Push(i);
                continue;
            }
            
            while (numberStack.Count > 0 && numbers[numberStack.Peek()] < numbers[i])
            {
                answer[numberStack.Peek()] = numbers[i];
                numberStack.Pop();
            }
            
            numberStack.Push(i);
        }
        
        foreach(int index in numberStack)
        {
            answer[index] = -1;
        }
        
        return answer;
    }
}

/*
public class Solution {
    // 2중 for문을 돌릴때 중복되는 부분이 어디지?
    
    // 0 -> 1~ n까지 0과비교
    // 1 -> 2 ~n 까지 1과 비교
    
    // 큰수를 찾았다면 멈추고 다음으로 넘어가면되고
    // 만약그런데 0과1이 같은수라면? 0과 1을 한번에 같이 찾아주면됨
    
    // 개선은 성공 시간초과 1개 발생
    
    public int[] solution(int[] numbers) 
    {
        int[] answer = new int[numbers.Length];
        
        for(int i =0; i< numbers.Length; i++)
        {
            
            if (answer[i] != 0)
            {
                continue;
            }
            
            int num1 = numbers[i];
            int num2 = -1;
            List<int> indexs = new List<int>();
            indexs.Add(i);
            
            for(int j =i+1; j < numbers.Length; j++)
            {
                if (num1 < numbers[j])
                {
                    num2 = numbers[j];
                    break;
                }
                else if (num1 == numbers[j])
                {
                    indexs.Add(j);
                }
            }
            
            foreach(int index in indexs)
            {
                answer[index] = num2;
            }
        }
        return answer;
    }
}
*/

/*
2중 for문으로 시간초과 발생 numbers의 최대길이가 1,000,000 이라서 -> 시간 초과 4개
public class Solution {
    // 현재 인덱스의 뒤에서부터
    public int[] solution(int[] numbers) {
        List<int> answer = new List<int>();
        
        for(int i =0; i< numbers.Length; i++)
        {
            int num1 = numbers[i];
            int num2 = -1;
            
            for(int j =i+1; j < numbers.Length; j++)
            {
                if (num1 < numbers[j])
                {
                    num2 = numbers[j];
                    break;
                }
            }
            
            answer.Add(num2);
       
        }
        return answer.ToArray();
    }
}
*/