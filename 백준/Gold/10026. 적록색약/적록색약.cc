// 1. 색약이 아니다 색상구분을 빨.초,파로 구분해서 구역을 구별한다.

// 2. 색약이다 색상구분을 파란색과 파란색이 아닌걸로 구분해서 구역을 구별한다.

#include <iostream>
#include <vector>
using namespace std;

int N;
string arr[100];
vector<vector<int>> check(100);
int dy[4] = {-1,1,0,0};
int dx[4] = {0,0,-1,1};
int redNum = 0;
int greenNum = 0;
int blueNum = 0;
int nBlueNum = 0;

void dfs(int y, int x, char color) {
	check[y][x] = 1;

	for (int i = 0; i < 4; i++) {
		int ny = y + dy[i], nx = x + dx[i];

		if (ny < 0 || ny >= N || nx < 0 || nx >= N) continue;
		
		if (check[ny][nx] == 0 && arr[ny][nx] == color)
			dfs(ny, nx, color);
	}

}

void dfs2(int y, int x) {
	check[y][x] = 1;

	for (int i = 0; i < 4; i++) {
		int ny = y + dy[i], nx = x + dx[i];

		if (ny < 0 || ny >= N || nx < 0 || nx >= N) continue;

		if (check[ny][nx] == 0 && arr[ny][nx] != 'B')
			dfs2(ny, nx);
	}

}
// 1. 파란색 시작 -> 파란색 계속 타고 감
// 2, 파란색 아닌ㄷ

int main() {
	cin >> N;

	for (int i = 0; i < N; i++) {
		string temp = "";
		cin >> temp;
		arr[i] = temp;
	}

	for (int i = 0; i < N; i++) {
		check[i].clear();
		check[i].resize(N,0);
	}

	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			if (check[i][j] == 0) {
				
				if (arr[i][j] == 'B') {
					blueNum++;
					dfs(i, j, 'B');
				}
				else if (arr[i][j] == 'R') {
					redNum++;
					dfs(i, j, 'R');
				}
				else if (arr[i][j] == 'G') {
					greenNum++;
					dfs(i, j, 'G');
				}	
			}	
		}
	}
	
	for (int i = 0; i < N; i++) {
		check[i].clear();
		check[i].resize(N, 0);
	}

	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			if (check[i][j] == 0 && arr[i][j] != 'B') {
				nBlueNum++;
				dfs2(i, j);
			}
		}
	}


	cout << blueNum + redNum + greenNum << " " << blueNum +nBlueNum;
	
}