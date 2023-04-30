#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

// 구글링
// dp[i][j] 
// i는 A문자열의 길이
// j는 B문자열의 길이가 된다.

// 나와있는 예제
// A가 ACAYKP이고
// B가 CAPCAK인 경우

// dp[1][0] A와 ""을 비교한 갯수 0
// dp[1][1] A와 C를 비교한 갯수 0 + 0
// dp[1][2] A와 CA를 비교한 갯수 0+ 0 + 1
// 
//1.해당 칸의 행과 열의 문자가 같을 때는 해당 칸의 왼쪽 대각선의 값에 + 1,
//2.해당 칸의 행과 열의 문자가 다를 때는 해당 칸의 왼쪽, 위의 값 중 큰 값을 가져온다.

// dp[6][1]~ dp[6][6]은
// A의 6번째 글자와 B의 1~6번째 글짜를 비교하는건데
// dp[i][j]칸을 실패했다면 dp[i-1][j]와 dp[i][j-1]중 더큰값을 저장한다.
// dp[i][j]칸을 성공했다면 dp[i-1][j-1] +1을 저장한다.

// CAPCAK와 ACAYK를 비교했을떄 K == K이므로
// CAPCA와 ACAY를 비교한 결과값 + 1이 저장된다.

// CAPCAK와 ACAYKP를 비교했을떄 K != P이므로
// CAPCA와 ACAYKP를 비교했을떄의 결과값과
// CAPCAK와 ACAYK를 비교했을떄의 결과값중 더큰값을 계승한다.
// 
// A를 기준으로 비교했을때와 B를 기준으로 비교했을떄가 모두 고려된다.

int dp[1001][1001];
int main() {
	string A, B;
	cin >> A >> B;

	for (int i = 1; i <= A.length(); i++) {
		for (int j = 1; j <= B.length(); j++) {
			if (A[i - 1] == B[j - 1])
				dp[i][j] = dp[i - 1][j - 1]+1;
			else {
				dp[i][j] = max(dp[i - 1][j], dp[i][j - 1]);
			}
		}
	}

	cout << dp[A.length()][B.length()];
}