using System;

public class Solution {
    public int solution(string my_string) {
        // 스트링을 돌면서 숫자를 찾는다
        // 숫자를 찾았으면 인덱스번호를 저장해두고 넘어간다.
        // 인덱스 번호가 저장이 된 상태인데 문자를 만났다면 인덱스 번호부터 현재 인덱스까지 SubString해서 int로 바꿔서 answer에 더해준다.
        int idx = -1;
        int answer = 0;
        
        for (int i=0; i < my_string.Length; i++){
            if ((int)my_string[i] > 57){
                
                if (idx != -1){
                    answer += int.Parse(my_string.Substring(idx, i-idx));
                    idx = -1;
                }
                    
            }
            else {
                if (idx == -1)
                    idx = i;
            }
        }
        
        if (idx != -1)
            answer += int.Parse(my_string.Substring(idx, my_string.Length - idx));
        
        return answer;
    }
}