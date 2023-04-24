#include <iostream>
#include <vector>
#include <string>
using namespace std;

vector<unsigned long long> fiboN(101, 0);

// 파도반 수열
// n-2 n-3을 더한값.
// fiboN[0]는 안씀

unsigned long long fibo(int n) {
	if (n < 4) {
		return 1;
		
	}
	if (fiboN[n] == 0) {
		fiboN[n] = fibo(n - 2) + fibo(n - 3);
	}
	return fiboN[n];
}


int main() {
	int T;
	cin >> T;
	while (T--) {
		int num;
		cin >> num;
		cout << fibo(num) << '\n';
	}
}