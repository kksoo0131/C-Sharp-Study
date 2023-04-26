
// ㅈㅈ 구글링 , 두개비교까지는 했는데 세개비교하는걸 생각못한듯 두개비교로 반례에서 막힘
// dp[0] = arr[0] = 0
// dp[1] = arr[1]
// dp[2] = arr[1] + arr[2]

// 3번 잔에서의 경우의수는
// arr[1] + 0 + arr[3]
// 0 + arr[2] + arr[3]
// a[1] + a[2] + 0 
// 결국 
// dp[n-3] + arr[n-1] + arr[n]
// dp[n-2] + arr[n]
// dp[n-1] -> 내가 생각 못한 부분
// 이미 n-1에서 한 결과가 더크다면 n을 더해서는 안된다.

#include <iostream>
#include <algorithm>

using namespace std;

int N;
int arr[10001];
int dp[10001];

// n번째 포도주를 마시는 방법은
// n-3 n-2 n-1 n이니까
// n-2 까지 마신양 + n
// n-3 + n-1 + n
int main() {
	cin >> N;
	for (int i = 0; i < N; i++) {
		cin >> arr[i];
	}
	dp[0] = 0;
	dp[1] = arr[0];
	dp[2] = dp[1] + arr[1];
	

	for (int i = 3; i <= N; i++) {
		// arr[i-1] 이 i번째 포도주
		unsigned long long temp1 = dp[i - 3] + arr[i - 2] + arr[i - 1];
		unsigned long long temp2 = dp[i - 2] + arr[i - 1];
		unsigned long long temp3 = dp[i - 1];
		dp[i] = max({ temp1, temp2,temp3 });
		
	}

	cout << dp[N] << '\n';
}
