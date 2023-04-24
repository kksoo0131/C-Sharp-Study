#include <iostream>
#include <vector>
using namespace std;

struct fibodata {
	int value;
	int zero;
	int one;
	fibodata(int v, int z, int o) : value(v), zero(z), one(o) {};
};
vector<fibodata> fiboN(41, fibodata(-1,0,0));

// 0과 1을 출력해야되니까
int fibo(int n) {
	if (fiboN[n].value == -1) {

		fiboN[n].value = fibo(n - 1) + fibo(n - 2);
		fiboN[n].zero = fiboN[n - 1].zero + fiboN[n - 2].zero;
		fiboN[n].one = fiboN[n - 1].one + fiboN[n - 2].one;
	}
	return fiboN[n].value;
}

int main() {
	int T;
	cin >> T;
	fiboN[0] = fibodata(0, 1, 0);
	fiboN[1] = fibodata(1, 0, 1);
	while (T--) {
		int num;
		cin >> num;
		fibo(num);
		cout << fiboN[num].zero << " " << fiboN[num].one <<'\n';
	}
}