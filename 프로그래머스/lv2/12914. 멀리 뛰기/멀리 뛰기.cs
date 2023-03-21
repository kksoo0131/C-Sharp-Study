using System.Collections.Generic;
public class Solution {
    Dictionary<int, long> dic = new Dictionary<int, long>();
    public long solution(int n) {    
        dic.Add(1,1); 
        dic.Add(2,2); 
            
        return fibo(n);    
    }
    
    long fibo(int n){
        if (dic.ContainsKey(n) == false)
            dic.Add(n, fibo(n-2) + fibo(n-1));
        return dic[n] % 1234567;
    }
}