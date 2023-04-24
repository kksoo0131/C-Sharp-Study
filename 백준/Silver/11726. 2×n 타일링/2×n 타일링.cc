#include <iostream>
#include <vector>
#include <string>
using namespace std;

vector<int> fiboN(1001, -1);

// 검색하고 풀었음
// n 번쨰 블록의 경우의수는
// n-1 블록에서 세로로 하나 더한 경우의수 +
// n-2 블록에서 가로로 두개 더한 경우의수 이다
// 그래서f(n) = f(n-1) + f(n-2)

int fibo(int n) {
	if (n < 3) {
		return n;
	}
	if (fiboN[n] == -1){
		fiboN[n] = (fibo(n - 1) + fibo(n - 2)) % 10007;
	}
	return fiboN[n];
}

int main() {

	int num;
	cin >> num;
	cout << fibo(num) << '\n';

}

