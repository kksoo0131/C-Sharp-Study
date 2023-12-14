using System;
using System.Collections.Generic;

public class RemainNumber
{
    public Dictionary<int, int> numbersDic{get; private set;} = new Dictionary<int, int>();    
        
    public RemainNumber(string numbers)
    {
        foreach(char c in numbers)
        {
            int i = int.Parse(c.ToString());
            if (!numbersDic.ContainsKey(i))
            {
                numbersDic.Add(i,0);
            }
            numbersDic[i]++;
        }
    }
    
    public RemainNumber(RemainNumber copy)
    {
        numbersDic = new Dictionary<int, int>(copy.numbersDic);
    }
}
public class Solution {
    HashSet<int> primeNumber = new HashSet<int>();
    
    public int solution(string numbers) {
        
        // 중복 선택 x, 하지만 같은 수가 여러 번 등장할 수는 있음
        
        // 첫자리에 가능한 수의 갯수를 반복, (0011) 이라면 2개가됨
        
        // 그러면 각 숫자가 몇개씩 있는지에 대한 정보도 파악이 되야함 -> Dictionary로 관리한다.
        
        // 다음에는 남은 수들중 선택 가능한 갯수를 고름 (011) 이 남아있다면 또 2개가되겠네? 이걸 반복해서 갯수를 구한다.
        
        // 1. 만들 수 있는 숫자를 탐색 (DFS)
        
        // 2. 소수인 경우 HashSet에 넣음
        
        // 3. HashSet의 Count 반환.
        
        
        
        RemainNumber dic = new RemainNumber(numbers);
        DFS("", dic);
        
        return primeNumber.Count;
    }
    
    public void DFS (string str, RemainNumber dic)
    {
        foreach(int i in dic.numbersDic.Keys)
        {
            if (dic.numbersDic[i] == 0) continue;
            RemainNumber newDic = new RemainNumber(dic);
            newDic.numbersDic[i]--;
            string tStr = str + i;
            int number = int.Parse(tStr);
            // 현재 숫자가 prime인지 체크
            DFS(tStr, newDic);
            if (CheckPrime(number))
            {
                primeNumber.Add(number);    
            }
            
            
        }
    }
    
    public bool CheckPrime(int number)
    {
        bool isPrime = true;
        
        if (number <= 1)
        {
            return false;
        }
        
        int temp = (int)Math.Sqrt(number);
        // 일단 임시로 구현
        for (int i =2; i<= temp; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        
        return isPrime;
        
    }
}