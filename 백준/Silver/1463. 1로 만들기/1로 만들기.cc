#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

vector<int> fiboN(1000001, -1);

// 3으로 나눈 수가 1을 만드는데 필요한 연산횟수
// 2로 나눈 수가 1을 만드는데 필요한 연산횟수
// 1을 뺀수가 1을 만드는데 필요한 연산회수
// 3가지중 가장 작은것 +1
int fibo(int n) {
	int arr[3] = {100001,100001,100001 };
	if (fiboN[n] == -1) {
		if (n % 3 == 0) { arr[2] = fibo(n / 3); }
		if (n % 2 == 0) { arr[1] = fibo(n / 2); }
		arr[0] = fibo(n - 1);
		

		fiboN[n] = *min_element(arr, arr + 3) + 1;
	}
	

	return fiboN[n];
}
             
int main() {

	int N;
	cin >> N;
	fiboN[1] = 0;
	fiboN[2] = 1;
	fiboN[3] = 1;
	cout << fibo(N) << '\n';
	

}
