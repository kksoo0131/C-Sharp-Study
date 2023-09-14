using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    // 1. n 을 k진수로 바꾼다.
    
    // k진수의 0을 기준으로 숫자를 나눈다.
    
    // 소수의 개수를 센다.
    
    // int 범위를 벗어날수 있다. ex .) 885733은 3진법으로 1122222222221
    
    // 해당 수가 소수인지 판별하려면
    // 2~제곱근 까지의 수로 나눴을때
    // 나누어 떨어지지 않는다면 소수임
    
    // 여기선 판별해야하는 소수의 개수는 적지만
    // 수의 범위는 큼
    
    // max 까지의 소수를 전부 구하는건 오버플로우가 발생하기때문에
    
    // 수의 갯수가 적은걸 이용해서 각각이 prime인지만 판별함
    public int solution(int n, int k) 
    {
        int answer = 0;
        long[] checkArr = SplitKNumber(n,k);
  
        foreach(long i in checkArr)
        {
            answer += PrimeCheck(i) ? 1 : 0;
        }
        
        return answer;
    }
    
    public long[] SplitKNumber(int n, int k)
    {
        string str = "";
        
        while(n != 0)
        {
            str += n % k;
            n /= k;
        }
        
        char[] charArr = str.ToCharArray();
        Array.Reverse(charArr);
        
        str = new string(charArr);
        // ToString이 아니라 new string을 해야됨
        
        string[] strArr = str.Split("0");
        List<long> list = new List<long>();
       
        for(int i =0; i< strArr.Length; i++)
        {
            long temp;
            if (long.TryParse(strArr[i], out temp))
            {
                list.Add(temp);
            }
        }
        
        // 빈 list를 ToArray()하면 런타임 에러?
        
        return list.Count == 0 ? new long[1] :list.ToArray();
        
    }
    
    public bool PrimeCheck(long number)
    {
        if( number < 2){
            return false;
        }
       int sqrt = (int)Math.Sqrt(number);
        bool result = true;
        
        for (long i = 2; i<= sqrt; i++)
        {
            if (number % i ==0 )
            {
                result = false;
                break;
            }
        }
        return result;
    }
}
/*
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    // 1. n 을 k진수로 바꾼다.
    
    // k진수의 0을 기준으로 숫자를 나눈다.
    
    // 소수의 개수를 센다.
    
    // int 범위를 벗어날수 있다. ex .) 885733은 3진법으로 1122222222221
    
    // 해당 수가 소수인지 판별하려면
    // 2~제곱근 까지의 수로 나눴을때
    // 나누어 떨어지지 않는다면 소수임
    
    // 여기선 판별해야하는 소수의 개수는 적지만
    // 수의 범위는 큼
    
    // max 까지의 소수를 전부 구하는건 별로임
    public int solution(int n, int k) 
    {
        int answer = 0;
        long[] checkArr = SplitKNumber(n,k);
        long max = checkArr.Max();
        bool[] isNotPrime = primeCheck(max);
        foreach(int i in checkArr)
        {
            answer += isNotPrime[i] ? 0 : 1;
        }
        
        return answer;
    }
    
    public long[] SplitKNumber(int n, int k)
    {
        string str = "";
        
        while(n != 0)
        {
            str += n % k;
            n /= k;
        }
        
        char[] charArr = str.ToCharArray();
        Array.Reverse(charArr);
        
        str = new string(charArr);
        // ToString이 아니라 new string을 해야됨
        
        string[] strArr = str.Split("0");
        List<long> list = new List<long>();
       
        for(int i =0; i< strArr.Length; i++)
        {
            long temp;
            if (long.TryParse(strArr[i], out temp))
            {
                list.Add(temp);
            }
        }
        
        // 빈 list를 ToArray()하면 런타임 에러?
        
        return list.Count == 0 ? new long[1] :list.ToArray();
        
    }
    
    public bool[] primeCheck(long max)
    {
        bool[] isNotPrime = new bool[max+1];
        isNotPrime[0] = true;
        if (isNotPrime.Length  <2) return isNotPrime;
        isNotPrime[1] = true;
        if (isNotPrime.Length  <3) return isNotPrime;
        
        
        
        for(long i=2; i< Math.Sqrt(isNotPrime.Length); i++)
        {
            // 해당 수가 소수인지 판별하려면
            // 2~제곱근 까지의 수로 나눴을때
            // 나누어 떨어지지 않는다면 소수임
            
            
            if (!isNotPrime[i])
            {
                for(long j = 2; j *i< isNotPrime.Length; j++)
                {
                    isNotPrime[j*i] = true;
                }
            }
        }
        
        return isNotPrime;
    }
}
*/