#include <iostream>
#include <vector>
using namespace std;

vector<vector<int>>paper;
int blue = 0;
int white = 0;
// 1. 종이가 모두 같은색인지 확인
// 시작인덱스, 가로, 세로길이가 필요함
// 2. 같은색이 아니면 자른다 == 범위를 줄여서 확인한다.
void cut(int x, int y, int N) {
	int temp = paper[y][x];
	bool check = true;
	
	for (int i = y; i < y + N; i++) {
		for (int j = x; j < x + N; j++) {
			if (temp != paper[i][j]) {
				check = false;
				break;
			}	
		}
		if (!check)
			break;
	}
	N /= 2;

	if (!check) {
		cut(x, y, N);
		cut(x, y+N, N);
		cut(x+N, y, N);
		cut(x+N, y+N, N);
	}
	else {
		if (!temp) {
			white++;
		}
		else
			blue++;
	}
	

}
int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);

	int N;
	cin >> N;

	paper.resize(N);

	for (int i = 0; i < N; i++) {
		vector<int> temp(N);
		for (int j = 0; j < N; j++) {
			cin >> temp[j];
		}
		paper[i] = temp;

	}

	cut(0, 0, N);
	cout << white << '\n' << blue;


	
}