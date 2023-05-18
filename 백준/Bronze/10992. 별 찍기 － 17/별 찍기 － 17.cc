#include <iostream>
using namespace std;


void function(int depth, int N, int start, int end) {
	if (depth > N) {
		return;
	}

	if (depth == 1) {
		for (int i = 0; i < start; i++) {
			cout << " ";
		}
		cout << "*";
	}
	else if (depth < N) {
		for (int i = 0; i < start; i++) {
			cout << " ";
		}
		cout << "*";
		for (int i = start + 1; i < end-1; i++) {
			cout << " ";
		}
		cout << "*";
	}
	else if (depth == N) {
		for (int i = 0; i < end; i++) {
			cout << "*";
		}
	}
	cout << '\n';
	function(depth + 1, N, start - 1, end + 1);
}
int main() {
	int N;
	cin >> N;
	function(1, N, N-1, N);
}