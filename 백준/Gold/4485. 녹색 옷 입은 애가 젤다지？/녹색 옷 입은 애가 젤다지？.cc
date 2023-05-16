// 0 ~ N-1 칸까지 최소비용으로 이동하는 문제

#include <iostream>
#include <deque>
using namespace std;

int N;
int dy[4] = { -1,1,0,0 };
int dx[4] = { 0,0,-1,1 };
int** arr;
bool** visited;
int** dist;
const int MAX_VALUE = 999999999;

void Clear() {
	for (int i = 0; i < N; i++) {
		delete[] arr[i];
		delete[] visited[i];
		delete[] dist[i];
	}

	delete[] arr;
	delete[] visited;
	delete[] dist;
}
void Input(int N) {
	arr = new int* [N];
	visited = new bool* [N];
	dist = new int* [N];

	for (int i = 0; i < N; i++) {
		arr[i] = new int[N];
		visited[i] = new bool[N];
		dist[i] = new int[N];

		for (int j = 0; j < N; j++) {
			cin >> arr[i][j];
			visited[i][j] = false;
			dist[i][j] = MAX_VALUE;
		}
	}
}
void Cave(pair<int,int> pos) {
	int y = pos.first;
	int x = pos.second;
	visited[y][x] = true;

	for (int i = 0; i < 4; i++) {
		int ny = y + dy[i], nx = x + dx[i];

		if (ny < 0 || ny >= N || nx < 0 || nx >= N)
			continue;

		if (!visited[ny][nx]) {
			if (dist[ny][nx] > dist[y][x] + arr[ny][nx])
				dist[ny][nx] = dist[y][x] + arr[ny][nx];
		}		
	}
}
pair<int,int> SelectShortDist() {
	int minDist = MAX_VALUE;
	pair<int, int> minPos = { -1,-1 };
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			if (!visited[i][j] && dist[i][j] != MAX_VALUE) {
				if (minDist > dist[i][j]) {
					minDist = dist[i][j];
					minPos = { i,j };
				}
			}
		}
	}

	return minPos;
}

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);
	int answerNumber = 1;
	while (true) {
		cin >> N;
		if (N == 0)
			break;
		Input(N);

		dist[0][0] = arr[0][0];
		Cave({ 0, 0 });

		while (true) {
			pair<int, int> nextPos = SelectShortDist();

			if (nextPos.first == -1) {
				break;
			}

			Cave(nextPos);
		}
		cout << "Problem " << answerNumber++ << ": " <<dist[N-1][N-1] << '\n';
		Clear();
		
	}
}