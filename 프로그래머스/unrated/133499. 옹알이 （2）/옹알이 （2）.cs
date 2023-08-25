using System;

public class Solution
    {
        
        public int solution(string[] babbling)
        {
            string[] continous = new string[]{"ayaaya","yeye","woowoo","mama"};
            string[][] possible = new string[4][];
            possible[0] = new string[]{"aya","ye","woo","ma"};
            possible[1] = new string[]{"ye","aya","woo","ma"};
            possible[2] = new string[]{"woo","ye","aya","ma"};
            possible[3] = new string[]{"ma","ye","woo","aya"};
            //string 배열을 순회하면서
            
            // 각각의 스트링을 만들수 있는지 판별

            // Replace로 하게되면 원래 안되다가 삭제해서 되는 경우가 발생함

            // 순서를 지켜서 확인을 해야된다.
            
            int count = 0;
            foreach(string babStr in babbling)
            {   
                string temp = babStr;
                
                // 연속인것을 걸러내야되고
                foreach(string conWord in continous)
                {
                    temp = temp.Replace(conWord,"");
                }
                
                if(temp.Length != babStr.Length) continue;
                
                
                int[] length = new int[4];
                
                for(int i =0; i< 4; i++)
                {
                    temp = babStr;
                    foreach(string posWord in possible[i])
                    {
                        temp= temp.Replace(posWord,"");
                    }
                    
                    length[i] = temp.Length;
                }
                // possible의 순서가 다를때도 0이여됨
                
                bool isSuccess = true;
                
                for(int i =0; i< 4; i++)
                {
                    if(length[i] != 0){
                        isSuccess = false;
                    }
                }
                
                if(isSuccess){
                    count++;
                }
                
                
            }
            


           return count;
        }
    
        
    }