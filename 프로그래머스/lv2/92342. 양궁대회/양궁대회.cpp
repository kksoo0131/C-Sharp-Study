#include <string>
#include <vector>

using namespace std;

int N;
vector<int> apeach;
vector<int> lion;
vector<int> answer;
int maxDiff = 0; // 최대 점수 차이

// dpt : 깊이
// asc : 현재 어피치 점수
// lsc : 현재 라이언 점수
// n : 현재 사용한 화살의 개수

void dfs(int dpt, int asc, int lsc, int n) {
	if (dpt == 11) 
	{
		if (lsc <= asc) return; // 끝까지 왔는데 점수가 부족함 

		lion[10] += N - n; // 남은 화살 0점에 넣기 (낮은 점수에 많을수록 우선순위가 높음)
		
		if (lsc - asc > maxDiff) { // 최대 점수 갱신
			answer = lion;
			maxDiff = lsc - asc;
		} 

		else if (lsc - asc == maxDiff) { // 최대 점수가 같아
			for (int i = 10; i >= 0; i--) { // 현재조합과 최대 조합을 비교
				if (lion[i] == answer[i]) continue;
				else {
					if (lion[i] > answer[i]) { // 이번조합이 더좋음
						answer = lion;
					}
					break;
				}
			}
		}
		return;
	}

	int next = apeach[dpt] + 1; // 해당 점수를 획득하는 경우
	if (next + n <= N) { // 최대 갯수 확인
		int nasc = asc; // 다음 깊이에서의 어피치 점수
		int nlsc = lsc + 10 - dpt; // 다음깊이에서의 라이언 점수

		if (next != 1) nasc -= 10 - dpt;
		// next가 1인경우는 0+1로 apeach가 선택을 하지않은경우 이기때문에
		// 점수를 빼주지않음
		lion.push_back(next);
		dfs(dpt + 1, nasc, nlsc, next + n);
		lion.pop_back(); 
		//획득 하는 경우를 dfs에 넣고 다시 뺴서
		//안넣는 경우를 계산한다.
	}

	lion.push_back(0);
	dfs(dpt + 1, asc, lsc, n);
	lion.pop_back();

}

vector<int> solution(int n, vector<int> info) {
	N = n;
	apeach = info;

	int total = 0;
	for (int i = 0; i < info.size(); i++) {
		if (info[i]) {
			total += (10 - i);
		}
	}

	dfs(0, total, 0, 0);

	if (maxDiff == 0) answer.push_back(-1);
	return answer;
}