#include <iostream>
#include <algorithm>
using namespace std;

int n;
int arr[10001];
int dp[10001];


// 최대한 비싸게 N개의 카드를 사는 방법

// 1으로 N 개를사려면 N / 1 * arr[1] 
// 2개짜리로 N개를 사려면 N / 2 * arr[2]+ 나머지를 구매
// 3개짜리로 N개를 사려면 N / 3 * arr[3] + 나머지를 구매

// f(N) = n / i * arr[i] + f(n%i) 

//n을 만드는 방법을 메모이제이션 30%
// 반례참고
// 아 무조건 비싸게 사는거라서
// 만약 12개를 만들떄 5 x 2 + 2 x1보다
// 5 x 1 + 4 x1 + 3 x1 이 더큰걸 고려해야함 그럼 위의 식으론 안됨.

int func(int n) {
	if (dp[n] == 0) {
		for (int i = 1; i <= n; i++) {
			int temp = arr[i];
			int R = n - i;

			if (R)
				R = func(R);

			if (temp + R > dp[n])
				dp[n] = temp + R;
		}
	}

	return  dp[n];
}

int main() {
	cin >> n;
	
	for (int i = 1; i <= n; i++) {
		cin >> arr[i];
	}
	cout << func(n);
	
}
