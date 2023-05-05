// 1 집의 단지 번호
// 0 집이없는곳
// 이어진 집은 단지로 취급한다.
// 이어진 집 == 상하좌우에 있는 집


#include <iostream>
#include <string>
#include <deque>
#include <algorithm>
using namespace std;


int N;
deque<int> arr[25];
int check[25][25];
int dy[4] = { 1,-1,0,0 };
int dx[4] = { 0,0,-1,1 };
deque<int> answer;

void dfs(int y, int x) {
	check[y][x] = 1;
	answer[answer.size()-1] += 1;
	
	for (int i = 0; i < 4; i++) {
		int nx = x + dx[i], ny = y + dy[i];

		if (ny < 0 || ny >= N || nx < 0 ||nx >= N) {
			continue; // 인덱스범위를 벗어남
		}

		if ((check[ny][nx] == 0) && (arr[ny][nx] != 0)) {
			// 방문한적 없고, 아파트가 있다면
			dfs(ny, nx);
		}
		
	}
	
}

int main() {
	
	cin >> N;
	
	for (int i = 0; i < N; i++) {
		string temp = "";
		cin >> temp;
		while (!temp.empty()) {
			arr[i].push_front(temp.back() - 48);
			temp.pop_back();
		}
	}

	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			if (check[i][j] == 0 && arr[i][j] != 0) {
				answer.push_back(0);
				dfs(i, j);
			}
		}
	}

	cout << answer.size() << '\n';

	sort(answer.begin(), answer.end());

	for (int i : answer) {
		cout << i << '\n';
	}

}