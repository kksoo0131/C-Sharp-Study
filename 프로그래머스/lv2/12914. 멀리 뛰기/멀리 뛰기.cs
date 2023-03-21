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
    // n에 도착하는 방법은 
    // n-1 지점에서 한칸 뛰는 경우, n-2 지점에서 두칸 뛰는 경우로 두가지 방법이 있다.
    // 그러므로 n-1 에 도착하는 방법의 수 + n-2 에 도착하는 방법의 수가 n의 도착하는 방법의 수가 된다.
}