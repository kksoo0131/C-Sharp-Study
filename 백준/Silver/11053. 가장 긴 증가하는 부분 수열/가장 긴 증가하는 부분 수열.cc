#include <iostream>
#include <algorithm>

using namespace std;

int n;
int dp[1001], arr[1001];
//검색해서품
int main() {
	cin >> n;

	for (int i = 0; i < n; i++) {
		cin >> arr[i];
	}

	int sum = 0;

	for (int i = 0; i < n; i++) {
		dp[i] = 1;
		for (int j = 0; j < i; j++) {
			// 이번에 선택한수 i를 앞의 수들과 비교함

			if (arr[i] > arr[j]) {
				dp[i] = max(dp[i], dp[j] + 1);
			}
			// 이미 구한 길이와 이번에 구한 길이를 비교해서 큰값을 저장
		}
		sum = max(sum, dp[i]);
		// 수열의 최대길이를 저장
	}

	cout << sum;
	return 0;
}