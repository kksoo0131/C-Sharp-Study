#include <iostream>
#include <vector>
#include <string>
using namespace std;

vector<int> fiboN(11, -1);

// 일단 1, 2 ,3 은 채워넣고
// n 은 n-1에서 1을더하는방법
// n-2 에서 2를 더하는 방법
// n-3 에서 3을 더하는 방법 3가지
// f(n) = f(n-1) + f(n-2) + f(n-3)

int fibo(int n) {
	if (fiboN[n] == -1){
		fiboN[n] = fibo(n - 1) + fibo(n - 2) + fibo(n - 3);
	}
	return fiboN[n];
}

int main() {

	int T;
	cin >> T;
	fiboN[1] = 1;
	fiboN[2] = 2;
	fiboN[3] = 4;
	while (T--) {
		int num;
		cin >> num;
		cout << fibo(num) << '\n';
	}
	

}

