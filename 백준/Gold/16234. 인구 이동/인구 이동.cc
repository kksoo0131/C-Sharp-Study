//몇일동안 인구이동을 해야하는가?
// 
// 각 나라들의 인구를 비교하며
// 완전탐색으로 연합을 구성한다.

// 시작좌표가 1,1인가?
#include <iostream>
#include <deque>

using namespace std;

int N, L, R;
int arr[51][51];
int dy[4] = { -1,1,0,0 };
int dx[4] = { 0,0,-1,1 };

int BFS(bool(&visited)[51][51], int y, int x) {
	deque<pair<int, int>> _unions;
	deque<pair<int, int>> dq;

	_unions.push_back({ y,x });
	dq.push_back({ y,x });

	visited[y][x] = true;
	int sum = arr[y][x];

	while (!dq.empty()) {
		int Y = dq.front().first, X = dq.front().second;
		dq.pop_front();

		for (int i = 0; i < 4; i++) {
			int ny = Y + dy[i], nx = X + dx[i];

			if (ny < 1 || ny > N || nx <1 || nx > N)
				continue;

			int diff = abs(arr[Y][X] - arr[ny][nx]);
			if (diff >= L && diff <= R && !visited[ny][nx]) {
				visited[ny][nx] = true;
				dq.push_back({ ny, nx });
				_unions.push_back({ ny, nx });
				sum += arr[ny][nx];
			}
		}
	}

	if (_unions.size() == 1) {
		return 0;
	}
	else {
		int avg = sum / _unions.size();

		for (pair<int, int> p : _unions) {
			arr[p.first][p.second] = avg;
		}

		return 1;
	}
	
	
}
int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);
	cin >> N >> L >> R;

	for (int i = 1; i <= N; i++) {
		for (int j = 1; j <= N; j++) {
			cin >> arr[i][j];
		}
	}

	int answer = 0;

	while (true) {
		
		bool visited[51][51];

		for (int i = 1; i <= 50; i++) {
			for (int j = 1; j <= 50; j++) {
				visited[i][j] = false;
			}

		}

		int swap = 0;
		for (int i = 1; i <= N; i++) {
			for (int j = 1; j <= N; j++) {
				if (!visited[i][j]) {
					swap += BFS(visited, i, j);
				}
			}
		}

		if (swap == 0)
			break;
		answer++;
	}

	cout << answer;
}