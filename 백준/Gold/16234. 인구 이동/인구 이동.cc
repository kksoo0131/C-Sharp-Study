// 옆나라와의 인구차이가 L이상 R이하라면 국경이 연결된다.
// 연합의 인구수를 모두 더해서 나눠가진다.

#include <iostream>
#include <deque>
#include <cmath>
using namespace std;

int N, L, R;
int arr[50][50];
int dy[4] = {-1,1,0,0};
int dx[4] = {0,0,-1,1};
int date = 0;

//연결되있는 칸에 접근을 할수 있게 저장해둬야됨
// 이번 턴에 봤는지 1.
// 이번 연합에 있었는지 1.

deque<pair<int, int>> bfs(pair<int,int> start, int(&visited)[50][50]) {
	deque<pair<int, int>> bfsdq;
	deque<pair<int, int>> unite;

	unite.push_back({ 0,0 }); // 0은 연합의 인원수, 1은 연합의 인구수
	bfsdq.push_back(start);
	
	visited[start.first][start.second] = 1;


	while (!bfsdq.empty()) {
		int y = bfsdq.front().first, x = bfsdq.front().second;
		bfsdq.pop_front();

		unite.push_back({y,x});
		unite.front().first++;
		unite.front().second += arr[y][x];

		for (int i = 0; i < 4; i++) {
			int ny = y + dy[i], nx = x + dx[i];
			if (ny < 0 || ny >= N || nx < 0 || nx >= N) continue;

			int difference = abs(arr[ny][nx] - arr[y][x]);
			if (visited[ny][nx] == 0 && difference >= L && difference <= R) {
				bfsdq.push_back({ny,nx});
				visited[ny][nx] = visited[y][x] + 1;
			}
		}
	}

	return unite;
}

bool movement() {
	int visited[50][50] = { 0 };
	deque<deque<pair<int, int>>> unite_dq;
	int uniteNum = 0;

	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			
			if (visited[i][j] == 0) {	
				unite_dq.push_back(bfs({ i,j }, visited));
			}
		}
	}

	for (deque<pair<int, int>> unite : unite_dq) {
		int num = unite.front().first;
		if (num > 1) uniteNum++;
		int sum = unite.front().second;
		int avg = sum / num;
		unite.pop_front();
		for (pair<int, int> p : unite) {
			arr[p.first][p.second] = avg;
		}
	}

	if (uniteNum == 0)
		return false;
	return true;
}

int main() {
	
	cin >> N >> L >> R;
	

	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			cin >> arr[i][j];
		}
	}

	while (movement()) {
		date++;
	};

	cout << date;
}
