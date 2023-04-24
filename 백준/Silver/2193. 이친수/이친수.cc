#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

struct EChinSoo {
	unsigned long long value;
	unsigned long long zero;
	unsigned long long one;
	EChinSoo(int v, int z, int o) : value(v), zero(z), one(o) {}
	
};


vector<EChinSoo> fiboN(91, EChinSoo(-1,0,0));

// n-1의 0으로끝나는 이친수 뒤에는 1과 0 모두올수있고
// 1으로 끝나는 이친수 뒤에는 0밖에 올수없다.
// 이친수의개수를 나누어서 저장해야됨
EChinSoo fibo(int n) {

	if (fiboN[n].value == -1) {		
		EChinSoo temp = fibo(n - 1);
		fiboN[n].zero = temp.zero + temp.one;
		fiboN[n].one = temp.zero;
		fiboN[n].value = fiboN[n].zero + fiboN[n].one;

	}
	

	return fiboN[n];
}
             
int main() {

	int N;
	cin >> N;
	fiboN[1] = EChinSoo(1,0,1);
	fiboN[2] = EChinSoo(1, 1, 0);
	cout << fibo(N).value << '\n';
	

}