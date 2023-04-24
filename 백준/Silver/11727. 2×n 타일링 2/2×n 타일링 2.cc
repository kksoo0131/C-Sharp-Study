#include <iostream>
#include <vector>
#include <string>
using namespace std;

vector<int> fiboN(1001, -1);

// n 번쨰 블록의 경우의수는
// n-1 블록에서 세로로 하나 더한 경우의수 +
// n-2 블록에서 가로로 두개 더한 경우의수 인데 방법이 2가지다 
// 그래서f(n) = f(n-1) + f(n-2) *2 ?

int fibo(int n) {
	if (fiboN[n] == -1){
		fiboN[n] = (fibo(n - 1) + fibo(n - 2)* 2) % 10007;
	}
	return fiboN[n];
}

int main() {

	int num;
	cin >> num;
	fiboN[0] = 0;
	fiboN[1] = 1;
	fiboN[2] = 3;
	cout << fibo(num) << '\n';

}

