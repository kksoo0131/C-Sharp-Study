// N,M까지 이동하는데 지나야하는 최소 칸수
// BFS

#include <iostream>
#include <deque>
using namespace std;


deque<string> maze;
int check[100][100];

int N, M;
int dy[4] = {-1,1,0,0};
int dx[4] = {0,0,-1,1};

int main() {
	
	string temp;
	cin >> N >> M;

	for (int i = 0; i < N; i++) {
		cin >> temp;
		maze.push_back(temp);
	}

	deque<pair<int, int>> dq;
	dq.push_back({ 0, 0 });
	check[0][0] = 1;
	while (!dq.empty()) {
		int y = dq.front().first, x = dq.front().second;
		dq.pop_front();

		
		for (int i = 0; i < 4; i++) {
			int ny = y + dy[i], nx = x + dx[i];

			if (ny < 0 || ny >= N || nx < 0 || nx >= M) {
				continue;
			}

			if (check[ny][nx] == 0 && maze[ny][nx] == '1') {
				dq.push_back({ ny, nx });
				check[ny][nx] = check[y][x] + 1;
			}
			
		}


	}

	cout << check[N-1][M-1];

}