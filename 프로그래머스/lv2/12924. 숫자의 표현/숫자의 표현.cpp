#include <vector>

using namespace std;

int solution(int n) {
    // 부분합 사용
    int answer = 0;
    vector<int> hap(n+1);
    hap[0] = 0; 
    
    for (int i =1; i<= n; i++){
        hap[i] = hap[i-1]+ i;
    }
       
    int start= n-1;
    int end = n;
    
    while (start >= 0)
    { 
        int number = hap[end] - hap[start];
        
        if (number > n)
            end--; 
        else if (number < n)
            start--;
        else{
            answer++;
            end--;
        }
    }
    
    return answer;
    
}