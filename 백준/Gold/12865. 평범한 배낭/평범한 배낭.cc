#include <iostream>
#include <algorithm>
#include <deque>
using namespace std;

// 배낭의 index를 돌면서 
// dp[]를 전부 확인해보면서 dp[i] !=0 이라면
// dp[i + weight] = dp[i] + value 를 해준다.
// 
// 근데 i == weight라면
// d[i]의 값과 이번 인덱스의 value 값을 비교해서 큰값을 넣어준다.
// (중복무게중 큰값을 저장하게됨)
// 
// 반례확인
// j를 확인하면서 dp[j+weight]를 업데이트하면
// 중복해서 업데이트하게됨 ex dp[j+weight+weight] 
// 
// 임시 queue에 저장해뒀다가 한꺼번에 비교해서 업데이트 83%

// 배낭의 물건을 N개 선택했을때 나올수있는 무게와 가치의 조합을
// 전부구해서. K보다 작은 무게일때 가장큰 가치를 구한다.

// 물건의 무게가 모두 K 보다 크면 0이 나와야됨

int N, K,answer;

int weight[101];
int value[101];

int dp[100001];

void Input() {
	for (int i = 1; i <= N; i++) {
		cin >> weight[i] >> value[i];
	}
}

void Solution() {
	for (int i = 1; i <= N; i++) { //배낭 탐색
		deque<pair<int,int>> dq_temp;
		if (weight[i] <= K) {
			dq_temp.push_back({ weight[i], value[i] }); // 이번 물품을 임시 queue에 추가
		}

		for (int j = 1; j + weight[i] <= K; j++) { // 무게 탐색
			
			if (dp[j] != 0) {
				dq_temp.push_back({ j + weight[i], dp[j] + value[i]});
			} 	

		}

		// deque에 저장된 값들을 보고 현재 저장되있는 dp값과
		// 비교해서 업데이트 해준다.
		for (pair<int, int> p : dq_temp) {
			dp[p.first] = max(dp[p.first], p.second);

			if (dp[p.first] > answer) {
				answer = dp[p.first];
				//최대값 갱신.
			}
		}
		
	}
}

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);
	cin >> N >> K;
	answer = 0;
	Input();
	Solution();
	cout << answer;
}