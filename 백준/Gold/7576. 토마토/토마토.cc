#include <iostream>
#include <deque>
using namespace std;

int dy[4] = {-1,1,0,0};
int dx[4] = {0,0,-1,1};
int N, M;
int answer = 0;
int** arr;
int** visited;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);
	cin >> M >> N;

	arr = new int*[N];
	
	for (int i = 0; i < N; i++) {
		arr[i] = new int[M];
		for (int j = 0; j < M; j++) {
			cin >> arr[i][j];
		}	
	}


	deque<pair<int, int>> dq;
	visited = new int* [N];
	for (int i = 0; i < N; i++) {
		visited[i] = new int[M];
		for (int j = 0; j < M; j++) {
			if (arr[i][j] == 1) {
				dq.push_back({ i,j });
				visited[i][j] = 1;
			}
				
			else
				visited[i][j] = 0;
		}
		
	}
	
	while (!dq.empty()) {
		int y = dq.front().first;
		int x = dq.front().second;
		dq.pop_front();

		if (visited[y][x] > answer) {
			answer = visited[y][x];
		}

		for (int i = 0; i < 4; i++) {
			int ny = y + dy[i], nx = x + dx[i];

			if (ny < 0 || ny >= N || nx < 0 || nx >= M)
				continue;

			if (visited[ny][nx] == 0) {

				if (arr[ny][nx] == 0) {
					arr[ny][nx] = 1;
					visited[ny][nx] = visited[y][x] + 1;
					dq.push_back({ ny, nx });
				}
			
			}
		}
	}

	bool check = true;

	for (int i = 0; i < N; i++) {
		for (int j = 0; j < M; j++) {
			if (arr[i][j] == 0) {
				check = false;
				break;
			}
		}
	}

	if (check) {
		cout << answer - 1;
	}
	else
		cout << -1;

	

}