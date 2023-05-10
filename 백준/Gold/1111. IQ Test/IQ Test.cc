#include <iostream>
#include <vector>
#include <string>
using namespace std;

vector<int> vec;
vector<int> pattern(201);
int N;
int answer = 0;

void findPattern() {
	
	int tmp = vec[1] - vec[0];
	int tmp2 = vec[2] - vec[1];

	int a;

	if (tmp != 0)
		a = tmp2 / tmp;
	else
		a = 0;

	// 패턴이 같다는 이야기는
	// 좌표평면에 그렸을떄 직선상에 있다는뜻

	int b = vec[1] - a * vec[0];

	for (int i = 2; i < N; i++) {
		if (vec[i] != vec[i - 1] * a + b) {
			cout << "B";
			return;
		}
	}

	cout << vec[N - 1] * a + b;
	
	
}


void inputData(int N) {

	vec.resize(N);
	for (int i = 0; i < N; i++) {
		cin >> vec[i];
	}
}

int main() {
	cin >> N;
	inputData(N);

	if (N == 1) {
		cout << 'A';
	}
	else if (N == 2) {
		if (vec[0] == vec[1])
			cout << vec[0];
		else
			cout << 'A';
	}
	else {
		findPattern();
		
	}	
	
}