using System;
using System.Linq;
using System.Collections.Generic;

class Solution
    {
        int[] nums;
        public int solution(int[] _nums)
        {
            nums = _nums;
            // 일단 3개의 수를 더하는 조합을 리스트로 뽑아서

            // 그 수들이 소수인지 검사
            // 소수검사는 에리스토의 체? -> 에라토스테네스의 체 ㅋㅋ

            List<int> combination = new List<int>();
            MakeList(combination);
            return primeCheck(combination);
        }

        public void MakeList(List<int> combination)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i+1; j < nums.Length - 1; j++)
                {
                    for (int k = j+1; k < nums.Length; k++)
                    {
                        combination.Add(nums[i] + nums[j] + nums[k]);
                    }
                }
            }

        }

        public int primeCheck(List<int> combination)
        {
            // 2부터 처음 선택하는 수는 소수

            // 그런데 선택 된 수의 배수들은 소수가 아님으로 
            // bool 배열을 통해서 NotPrime = true 처리를한다.

            int max = combination.Max();
            int count = 0;
            bool[] NotPrime = new bool[max+1];


            for (int i = 2; i <= max; i++)
            {
                if (NotPrime[i]) continue;

                for (int j = i * 2; j <= max; j += i)
                {
                    NotPrime[j] = true;
                }
            }

            foreach (int num in combination)
            {
                if (!NotPrime[num])
                {
                    count++;
                }
                
            }

            return count;

        }
    }