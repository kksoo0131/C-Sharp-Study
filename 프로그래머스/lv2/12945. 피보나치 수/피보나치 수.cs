using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    Dictionary <int, int> dic = new Dictionary<int, int>();
    public int solution(int n) {
        dic.Add(0,0);
        dic.Add(1,1);
        return fibo(n);
    }
    
    int fibo(int n){
        if (dic.ContainsKey(n) == false)
            dic.Add(n , fibo(n-1)  % 1234567 + fibo(n-2)  % 1234567);    
        return dic[n] % 1234567;         
    }
}