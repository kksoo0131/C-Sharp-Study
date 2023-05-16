// 0 ~ N-1 칸까지 최소비용으로 이동하는 문제

#include <iostream>
#include <queue>
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

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);
	int answerNumber = 1;
	while (true) {
		cin >> N;
		if (N == 0)
			break;
		Input(N);

		priority_queue<pair<int, int>, vector<pair<int, int>>, greater<pair<int, int>>> pq;
		dist[0][0] = arr[0][0];
		pq.push({ dist[0][0],0 });

		while (!pq.empty()) {
			
			int curDist = pq.top().first;
			int curY = pq.top().second / N;
			int curX = pq.top().second % N;
			pq.pop();

			visited[curY][curX] = true;

			for (int i = 0; i < 4; i++) {
				int ny = curY + dy[i], nx = curX + dx[i];

				if (ny < 0 || ny >= N || nx < 0 || nx >= N)
					continue;

				if (!visited[ny][nx] && dist[ny][nx] > curDist + arr[ny][nx]) {
					dist[ny][nx] = curDist + arr[ny][nx];
					pq.push({ dist[ny][nx], ny * N + nx });
				}
			}	
		}

		cout << "Problem " << answerNumber++ << ": " <<dist[N-1][N-1] << '\n';
		Clear();
		
	}
}