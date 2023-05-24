//그래프를 입력 받아서
//연결 요소의 개수를 출력
//몇개로 나누어져 있는지 인가?
#include <iostream>
#include <deque>
#include <algorithm>

using namespace std;

void DFS( deque<int>* arr, bool* visited, int n) {

	if (visited[n]) return;
	visited[n] = true;
	for (int i : arr[n]) {
		DFS(arr, visited, i);
	}


}
int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);

	int N, M;
	cin >> N >> M;

	deque<int>* arr = new deque<int>[N + 1];

	for (int i = 0; i < M; i++) {
		int tA, tB;
		cin >> tA >> tB;

		arr[tA].push_back(tB);
		arr[tB].push_back(tA);
	}

	for (int i = 0; i <= N; i++) {
		sort(arr[i].begin(), arr[i].end());
	}

	bool* visited = new bool[N + 1];
	fill(visited, visited + N + 1, false);
	int answer = 0;
	for (int i = 1; i <= N; i++) {
		if (visited[i]) continue;
		DFS(arr, visited, i);
		answer++;
	}

	cout << answer;
}