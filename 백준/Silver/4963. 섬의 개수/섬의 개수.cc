// 대각선 이동도 가능 9방향이동


#include <iostream>
#include <vector>
using namespace std;

int w, h;

vector<vector<int>> arr;
vector<vector<int>> check;
int answer = 0;
int dy[9] = { -1,-1,-1,0,0,0,1,1,1 };
int dx[9] = { -1,0,1,-1,0,1,-1,0,1 };


void dfs(int y, int x) {
	check[y][x] = 1;

	for (int i = 0; i < 9; i++) {
		int ny = y + dy[i], nx = x + dx[i];
		if (ny < 0 || ny >= h || nx < 0 || nx >= w) {
			continue;
		}
		if (arr[ny][nx] == 1 && check[ny][nx] == 0) {
			dfs(ny, nx);
		}

	}
}

void islandNumber() {
	arr.clear(), check.clear();
	arr.resize(h), check.resize(h);
	
	for (int i = 0; i < h; i++) {
		vector<int> temp(w,0);
		vector<int> temp_check(w, 0);
		arr[i] = temp;
		check[i] = temp_check;
		for (int j = 0; j < w; j++) {
			cin >> arr[i][j];
		}
	}

	for (int i = 0; i < h; i++) {
		for (int j = 0; j < w; j++) {
			if (arr[i][j] == 1 && check[i][j] == 0) {
				answer++;
				dfs(i, j);
			}
		}
	}
	cout << answer << '\n';
	answer = 0;
}

int main() {

	while (true) {
		cin >> w >> h;

		if (w == 0)
			break;
		islandNumber();
	}
	
}