using System.Collections.Generic;
public class Solution {
    Dictionary<int, int> dic = new Dictionary<int, int>();
    public int solution(int n) {    
        dic.Add(1,1); 
        dic.Add(2,2); 
            
        return fibo(n);    
    }
    
    int fibo(int n){
        if (dic.ContainsKey(n) == false)
            dic.Add(n, fibo(n-2) + fibo(n-1));
        return dic[n] % 1234567;
    }
}