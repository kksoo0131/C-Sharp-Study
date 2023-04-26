#include <iostream>
#include <algorithm>

using namespace std;
int T;

// 스티커를 고르면 상하좌우의 스티커는 고를수없음
// n번째 스티커를 고른다면 
// n-2번쨰 스티커의 합 + n 으로 가는느낌?
// 50+만약에 70을 고르려면그전 50을 안골라야

//  50, 30    50>> 
//  50+50, 30+10  100>>
// 50+50+100, 50+70, 30+10+70, 30+ 100  200>>

// 0-1, 1-2, 0-3  dp[0][j] = dp[1][j-1] + arr[0][j] 와
// 1-1, 0-3		  dp[0][j] =  dp[1][j-2] + arr[0][j]

//2차원 배열 동적할당 (스택오버플로우)
// 98퍼 실패? 왜지
// n이 1일때와 2일때를 고려안했음 ( 게시판 반례확인)
int main() {
	cin >> T;
	while (T--) {
		int length;
		cin >> length;
		int** arr = new int*[2];
		int** dp = new int*[2];
		unsigned long long answer = 0;

		for (int i = 0; i < 2; i++) {
			arr[i] = new int[100000]{0};
		}
		for (int i = 0; i < 2; i++) {
			dp[i] = new int[100000]{0};
		}
		

		for (int i = 0; i < 2; i++) {
			for (int j = 0; j < length; j++) {
				cin >> arr[i][j];
			}
		}
		dp[0][0] = arr[0][0];
		dp[1][0] = arr[1][0];
		dp[0][1] = dp[1][0] + arr[0][1];
		dp[1][1] = dp[0][0] + arr[1][1];

		for (int j = 2; j < length; j++) {
			for (int i = 0; i < 2; i++) {
				if (i == 0) {
					dp[i][j] = max(dp[1][j - 1] + arr[0][j],
						dp[1][j - 2] + arr[0][j]);
				}
				else {
					dp[i][j] = max(dp[0][j - 1] + arr[1][j],
						dp[0][j - 2] + arr[1][j]);
				}

				if (dp[i][j] > answer)
					answer = dp[i][j];
			}
		}
		if (length == 1) {
			answer = max(dp[0][0], dp[1][0]);
		}
		else if (length == 2) {
			answer = max(dp[0][1], dp[1][1]);
		}

		cout << answer << '\n';

	}	
	
}
