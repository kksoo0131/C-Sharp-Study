#include <iostream>
using namespace std;

char arr[3072][6143];

void draw(int row, int col) {
	//꼭짓점을 기준으로 삼각형을 찍는다.
	arr[row][col] = '*';
	
	arr[row + 1][col - 1] = '*';
	arr[row + 1][col + 1] = '*';

	for(int i = 0; i < 5; i++) {
		arr[row + 2][col - 2 + i] = '*';
	}
}

void triangle(int N, int row, int col) {
	if (N == 3) {
		draw(row, col);
		return;
	}

	// 큰 삼각형 하나는 작은삼각형 3개로 이루어져 있다
	// row,col은 삼각형의 꼭짓점의 y,x좌표

	//꼭짓점을 유지하면서 크기만 작아진 삼각형
	triangle(N / 2, row, col);
	//꼭짓점을 기준으로 왼쪽 삼각형
	triangle(N / 2, row + N / 2, col - N / 2);
	//꼭짓점을 기준으로 오른쪽 삼각형
	triangle(N / 2, row + N / 2, col + N / 2);

}

int main() {
	int N;
	cin >> N;

	for (int i = 0; i < N; i++) {
		for (int j = 0; j < 2 * N - 1; j++) {
			arr[i][j] = ' ';
		}
	}

	triangle(N, 0, N - 1);

	for (int i = 0; i < N; i++) {
		for (int j = 0; j < 2 * N - 1; j++) {
			cout << arr[i][j];
		}

		cout << '\n';
	}
}