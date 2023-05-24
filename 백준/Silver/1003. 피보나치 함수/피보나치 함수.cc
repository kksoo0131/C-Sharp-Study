//피보나치 함수의 0과 1이 몇번 호출되는지 갯수를 세서 출력해라

#include <iostream>
#include <deque>
using namespace std;

pair<int,int> dp[41];

pair<int, int> fibo(int n) {

	if (n == 0) {
		return { 1,0 };
	}
	else if (n == 1) {
		return { 0,1 };
	}
	
	
	if (dp[n].first == 0 && dp[n].second ==0) {
		pair<int, int> temp1 = fibo(n - 1);
		pair<int, int> temp2 = fibo(n - 2);

		dp[n].first = temp1.first + temp2.first;
		dp[n].second = temp1.second + temp2.second;
	}
	
	return {dp[n].first, dp[n].second};

}
int main() {
	int T, N;
	cin >> T;

	while (T--) {
		cin >> N;

		pair<int,int> answer = fibo(N);
		cout << answer.first << " " << answer.second << '\n';
	}
}