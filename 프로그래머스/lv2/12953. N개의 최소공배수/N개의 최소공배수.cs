public class Solution {
    public int solution(int[] arr) {
        int answer = arr[0];
        
        for (int i = 1; i < arr.Length; i++){
            if (answer >= arr[i])
                answer = answer * arr[i] / gcd(answer, arr[i]);
            else 
                answer = answer * arr[i] / gcd(arr[i], answer);
        }
        return answer;
    }
    int gcd (int a, int b){
        if (b == 0)
            return a;
        return gcd(b, a % b);
    }
}