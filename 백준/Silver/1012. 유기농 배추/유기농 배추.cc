#include <iostream>
#include <vector>
using namespace std;

// 이어져있는 배추는 하나의 지렁이로 커버가 가능하다

// 배추가 이어져있는건 상하좌우 확인
// (x-1,y),(x+1,y), (x,y-1), (x,y+1) 


int T, M, N, K;
vector<vector<int>> position; 	// 0 => Y 좌표, 1 => X좌표
vector<vector<int>> visited;
pair<int, int> dir[4] = { {-1,0}, {1,0}, {0,1}, {0,-1} };

// 이어진곳을 모두방문
void dfs(pair<int,int > p) {
	int y = p.first;
	int x = p.second;
	visited[y][x] = 1;

	for (pair<int, int> i : dir) {
		int y_next = y + i.first;
		int x_next = x + i.second;
		if (x_next < 0 || x_next >= M)
			continue; // X 인덱스 범위를 벗어남

		if (y_next < 0 || y_next >= N)
			continue; // Y 인덱스 범위를 벗어남

		// 확인한 방향에 배추가있고, 아직방문하지 않았다면
		if (position[y_next][x_next] == 1) {
			if (visited[y_next][x_next] == 0)
				dfs({ y_next , x_next });
		}
	}

}
int main() {
	cin >> T;
	while (T--) {
		cin >> M >> N >> K;
		int answer = 0;
		position.resize(N), visited.resize(N);
		for (int i = 0; i < N; i++) {
			vector<int> temp(M, 0);
			vector<int> temp2(M, 0);
			position[i] = temp;
			visited[i] = temp2;
		}
		
		for (int i = 1; i <= K; i++) {
			int x, y;
			cin >> x >> y;
			position[y][x] = 1;
		}

		for (int i = 0; i < N; i++) {
			for (int j = 0; j < M; j++) {
				if (position[i][j] ==1 &&visited[i][j] == 0) {
					dfs({ i,j });
					answer++;
				}	
			}
		}

		cout << answer << '\n';


	}


}