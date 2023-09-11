using System;

public class Solution {
    // 가입 날짜 부터 10일 동안 내가 원하는 제품을 모두 구입할 수 있는 지 판별
    // 가능한 날짜를 return
    
    // 10일 이하로 날짜가 남으면 어차피 불가능함
    public int solution(string[] want, int[] number, string[] discount) 
    {
        int[] check = new int[number.Length];
        int answer = 0;
        
        for(int i=0; i< 10;i++)
        {
            int index;
            if(CheckItem(discount[i],want,out index)) check[index]++;    
        }
        
        answer += EqualArr(check, number) ? 1:0;
        
        for(int i= 10; i< discount.Length; i++)
        {
            int index;
            if(CheckItem(discount[i-10],want,out index)) check[index]--;  
            if(CheckItem(discount[i],want,out index)) check[index]++;  
            answer += EqualArr(check, number) ? 1:0;
            
        }
            
        
        return answer;
    }
    
    public bool CheckItem(string s, string[] want, out int index)
    {
        index = Array.IndexOf(want, s);
        
        if(index == -1)
        {
            return false;
        }
        
        
        return true;
    }
    
    public bool EqualArr(int[] arr1, int[] arr2)
    {
        for(int i =0; i< arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
                
        }
        
        return true;
    }
}