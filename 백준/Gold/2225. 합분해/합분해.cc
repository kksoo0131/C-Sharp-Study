#include <iostream>
using namespace std;
// dp[K][N] 합의 개수를 저장해야겠네

// 0~6으로 4번
// 1 1 1 1 1 1 1
// 1 2 3 4 5 6 7
// 1 3 6 10 15 21 28
// 1 4 10 20 35 56 84

// dp[i][j] = dp[i][j-1] + dp[i-1][j];
int main() {
	int N, K;
	int dp[201][201]{0};
	cin >> N >> K;

	for (int i = 1; i <= K; i++) {
		dp[i][0] = 1;
		for (int j = 1; j <= N; j++) {
			dp[i][j] = (dp[i][j - 1] + dp[i - 1][j]) % 1000000000;
		}
	}

	cout << dp[K][N];
	
}