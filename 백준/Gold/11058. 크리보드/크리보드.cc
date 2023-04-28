// 1. A를 출력
// 2. 화면을 전체 선택
// 3. 전체 선택한 내용을 버퍼에 복사
// 4. 버퍼를 화면에 출력된 문자열뒤에 복사한다.
// N번 눌렀을 때 가장 길게 출력하기



#include <iostream>
#include <algorithm>
using namespace std;

unsigned long long dp[101];

int main() {
	int N;
	cin >> N;
	for (int i = 1; i <= 5; i++) {
		dp[i] = i;
	}

	for (int i = 6; i <= N; i++) {
		dp[i] = max({ dp[i - 1] + 1,// +A
			dp[i - 3] * 2,// acv
			dp[i - 4] * 3,// acvv
			dp[i - 5] * 4 }); // acvvv		
	}
	
	cout << dp[N];
}