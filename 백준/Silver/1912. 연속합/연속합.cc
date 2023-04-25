#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int n;
int arr[100000];
int dp[100001];
int answer = 0;
// 
int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);
	

	//보고함
	//
	// n번째에서 생각할수있는 경우의수는?
	// 
	// n-1번째까지의 합과 n을 비교해서
	// 1. n이 더크다면 sum = n
	// 2. n-1 + n 이 더크다면 sum += n 
	// 
	// 내가 헷갈린 부분은
	// 0~ n-1보다 n이 더크지만
	// 1~ n-1이 n보다 클수있지않나?
	// >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
	// 상향식으로 위의 비교를 하게되면 처음에
	// 0+1 보다 1이 큰가를 비교하게된다.
	// 0+1이 선택 됬다면
	// 0~ n-1이, 1~n-1보다 크다는전제가깔리게된다.
	int n;
	cin >> n;
	for (int i = 0; i < n; i++) {
		cin >> arr[i];
	}
	dp[0] = arr[0];

	for (int i = 1; i < n; i++) {
		int series = dp[i - 1] + arr[i];
		dp[i] = series < arr[i] ? arr[i] : series;
	}

	int max_value = *max_element(dp, dp + n);

	cout << max_value;

}