#include <iostream>
#include <vector>
using namespace std;

vector<int> vec;
vector<int> check;

void dfs(int N) {
	check[N] = 1;
	if (check[vec[N]] == 0) {
		dfs(vec[N]);
	}
}

int main() {
	int T, N;
	cin >> T;

	while (T--) {
		cin >> N;
		int answer = 0;
		vec.clear();
		vec.resize(N+1,0);
		check.clear();
		check.resize(N+1,0);
		
		for (int i = 1; i <= N; i++) {
			cin >> vec[i];
		}

		for (int i = 1; i <= N; i++) {
			if (check[i] == 0) {
				dfs(i);
				answer++;
			}
		}

		cout << answer << "\n";
	}
}