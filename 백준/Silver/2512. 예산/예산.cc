#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

// 값의 범위에서 이분탐색을하여
// 최적의 값을 찾는다.

long long N, total, answer,M;
vector<long long> countryBudget;

bool AssignBudget(long long budget) {
	// budget은 조사해볼 상한예산을 의미함

	if (budget > M) return false; 
	// 상한이 너무크다.

	long long sum = 0;

	for (long long x : countryBudget) {
		sum += min(x, budget); 
	}
	// budget을 상한을 했을때 예산의 총합이
	// total 을 초과하는지 

	if (sum <= total) return true;
	else return false;
}
long long BinarySearch(long long start, long long end) {
	// start, end는 상한 예산의 범위 mid 는 상한예산이다.
	

	while (start <= end) {
		long long mid = (start + end) / 2;
		if (AssignBudget(mid)) {
			answer = max(answer, mid);
			start = mid + 1;
		}
		else {
			end = mid - 1;
		}
	}

	return end;

}
int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);

	cin >> N;
	countryBudget.resize(N);

	for (int i=0; i < N; i++) {
		cin >> countryBudget[i];
		M = max(countryBudget[i], M);
	}

	cin >> total;

	BinarySearch(0, total);

	cout << answer;
}
