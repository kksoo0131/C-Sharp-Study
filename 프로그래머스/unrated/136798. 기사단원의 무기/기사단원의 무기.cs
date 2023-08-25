using System;
public class Solution {
    public int solution(int number, int limit, int power) {
        // 기사의 번호의 약수에 해당하는 무기를 구매
        
        // 제한 수치보다 큰 무기인 경우 지정해준 무기를 구매해야됨
        
        // 모든기사에게 무기를 만들어주기 위한 철의 무게를 계산해야됨
        
        // 1. 각 기사들의 약수의 개수 즉, 필요한 무기의 공격력을 리스트로 만들어준다.
        
        // 기사의 번호는 1번부터기 떄문에 0을 버림
        int[] array = new int[number+1];
        int answer = 0;
        
        for(int i =1; i<= number; i++)
        {
            for (int j = i; j <= number; j+=i)
            {
                array[j] += 1;
            }
            
        }
        
        //이제 배열을 돌면서 limit보다 큰값의 경우 power을 더함
        
        for(int i =1; i< number+1; i++)
        {
            answer += array[i] > limit ? power : array[i];
        }
        
        return answer;
    }
    
}
/*

시간초과 발생 테스트 케이스 : 11~16,18,24~25

number가 100,000 배열의길이가 10만이 되고 

각 약수를 구할때 100,000 * 100,000의 이중 for문으로 작동하기 때문에 개선이 필요하다

앞에서 부터 해당 수의 배수를 구하면서 전부 +1씩 해주는 방식은 어떤가?



public class Solution {
    public int solution(int number, int limit, int power) {
        // 기사의 번호의 약수에 해당하는 무기를 구매
        
        // 제한 수치보다 큰 무기인 경우 지정해준 무기를 구매해야됨
        
        // 모든기사에게 무기를 만들어주기 위한 철의 무게를 계산해야됨
        
        // 1. 각 기사들의 약수의 개수 즉, 필요한 무기의 공격력을 리스트로 만들어준다.
        
        // 기사의 번호는 1번부터기 떄문에 0을 버림
        int[] array = new int[number+1];
        int answer = 0;
        
        for(int i =1; i<= number; i++)
        {
            array[i] = NumDivisor(i);
        }
        
        //이제 배열을 돌면서 limit보다 큰값의 경우 power을 더함
        
        for(int i =1; i< number+1; i++)
        {
            answer += array[i] > limit ? power : array[i];
        }
        
        return answer;
    }
    
    public int NumDivisor(int num)
    {
        int count =0;
        for(int i =1; i <= num ; i++)
        {
            count += num % i == 0 ? 1 :0;
        }
        return count;
    }
}
*/