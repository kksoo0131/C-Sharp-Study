#include <iostream>
#include <vector>
using namespace std;

vector<vector<bool>> paper;
void starcut(int x, int y, int N) {
	if (N == 1)
		return;

	int temp = N / 3;

	for (int i = y; i < y + temp; i++) {
		for (int j = x; j<x + temp; j++) {
			paper[i+temp][j+temp] = false;
		}
	}

	for (int i = y; i < y+N; i += temp) {
		for (int j = x; j < x+N; j += temp) {
			starcut(i, j, temp);
		}
	}
	
}
int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);

	int N;
	cin >> N;

	paper.resize(N);
	for (int i = 0; i < N; i++) {
		vector<bool> temp(N, true);
		paper[i] = temp;
	}

	starcut(0, 0, N);
	
	for (vector<bool> line : paper) {
		for (bool star : line) {
			if (star) {
				cout << "*";
			}
			else {
				cout << " ";
			}
		}
		cout << '\n';
	}
}