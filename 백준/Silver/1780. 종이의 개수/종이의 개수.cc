// 

#include <iostream>
#include <vector>
using namespace std;

int N;
int answer[3];
vector<int>arr[2187];

void dfs(int N,int y, int x) {

	if (N == 1) {
		answer[arr[y][x]+1] += 1;
		return;
	}

	// 종이의 왼쪽 모서리를 y,x로 종이의 길이를 N으로 둔다.
	int temp = arr[y][x];
	bool check = true;
	for (int i = y; i < y + N; i++) {
		for (int j = x; j < x + N; j++) {
			if (temp != arr[i][j]) {
				check = false;
				break;
			}
		}

		if (!check)
			break;
	}

	if (!check) {
		for (int i = 0; i < 3; i++) {
			int ny = y + i * N / 3;
			for (int j = 0; j < 3; j++) {
				int nx = x + j * N / 3;
				dfs(N / 3, ny, nx);
			}
		}
	}
	else {
		answer[temp+1] += 1;
		return;
	}


}

int main() {
	cin >> N;

	for (int i = 0; i < N; i++) {
		arr[i].resize(N);
		for (int j = 0; j < N; j++) {	
			cin >> arr[i][j];
		}
	}

	fill(answer, answer + 3, 0);
	dfs(N, 0, 0);

	for (int i : answer) {
		cout << i << '\n';
	}
}
