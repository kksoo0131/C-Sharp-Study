
#include <iostream>
#include <vector>
using namespace std;
int N;
int arr[100][100];
vector<vector<int>> check;
int dy[4] = {-1,1,0,0};
int dx[4] = { 0,0,-1,1 };
int answer = 0;
int maxA = 0;

\
void checkReset() {
	check.resize(N);
	for (int i = 0; i < N; i++) {
		check[i].clear();
		check[i].resize(N, 0);
	}
}

void dfs(int y, int x, int depth) {

	check[y][x] = 1;

	for (int i = 0; i < 4; i++) {
		int ny = y + dy[i], nx = x + dx[i];
		if (ny < 0 || ny >= N || nx < 0 || nx >= N) continue;
		if (check[ny][nx] == 0 && arr[ny][nx] > depth) {
			dfs(ny, nx, depth);
		}
	}
}

void sink(int depth) {
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			if (check[i][j] == 0 && arr[i][j] > depth) {
				answer++;
				dfs(i, j, depth);
			}

		}
	}
}

int main() {
	cin >> N;
	checkReset();
	
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			cin >> arr[i][j];
		}
	}
	
	for (int i = 0; i < 101; i++) {
		answer = 0;
		checkReset();
		sink(i);

		if (answer > maxA) {
			maxA = answer;
		}
	}
	
	cout << maxA;
}