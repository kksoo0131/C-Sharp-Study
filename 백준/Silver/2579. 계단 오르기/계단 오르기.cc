#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

// 마지막 계단은 밟아야됨
// 이전 3칸을 봐야되나?
// n-3까지의 수 + n-1 + n
// n-2까지의수 + n 중에 선택해야된다.
// 
// n == 1 10
// n == 2 10+20 = 30
// n == 3 20+15 = 35
// n == 4 20+15+25 (2,3번인덱스 둘중에 하나만 선택해야됨) = 60
// n == 5 30+25+10 = 65
// n == 6 35+25+10 = 70

int n;
int arr[301];
int dp[301] = {0};
int main() {
	cin >> n;
	for (int i = 0; i < n; i++) {
		cin >> arr[i];
	}

	dp[1] = arr[0];
	dp[2] = dp[1] + arr[1];
	for (int i = 3; i <= n; i++) {
		// arr[0] 가 첫번쨰 계단 == i번째 계단은 arr[i-1]
		int temp1 = dp[i - 3] + arr[i - 2] + arr[i-1];
		int temp2 = dp[i - 2] + arr[i-1];
		if (temp1 > temp2) {
			dp[i] = temp1;
		}
		else {
			dp[i] = temp2;
		}
	}

	cout << dp[n];
}
