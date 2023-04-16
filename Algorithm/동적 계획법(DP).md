## 동적 계획법 (Dynamic Programming)

- 하나의 큰 문제를 여러 개의 작은 문제로 나누어서 그 "결과를 저장하여 재활용"(Memoization)한다.
- 일반적인 재귀를 단순하게 사용 시 동일한 작은 문제들이 여러 번 반복되어 비효율적인 계산이 될 수 있다.
- ex) 피보나치 수열 문제 f(n) = f(n-1) + f(n-2) 인데 n-1에서 구한 값을 n-2에서 또 다시 구하게 된다.

## 조건
1. 동일한 작은 문제들이 반복하여 나타나는 경우
2. 부분 문제의 최적 결과 값을 사용해 전체 문제의 최적 결과를 낼 수 있는 경우

## 방식
1. Bottom_Up (상향식) - 반복문 사용, 작은 문제들부터 답을 구해가며 전체 문제의 답을 찾는다.
``` cpp
#include <iostream>
#include <vector>
using namespace std;

int main() {
	int N;
	cin >> N;
	vector<int> vec(N+1);
	vec[1] = 1;
	
	for (int i = 2; i <= N; i++) {
		vec[i] = vec[i - 1] + vec[i - 2];
	}

	cout << vec[N];

}
```
3. Top-Down (하향식) - 재귀 사용, 큰 문제를 해결하기 위해 작은 문제를 호출
``` cpp
#include <iostream>
#include <vector>
using namespace std;

vector<int> memoization;
int fibo(int n) {
	if (n == 0 || n == 1) {
		return n;
	}
		
	if (memoization[n] == 0) {
		memoization[n] = fibo(n - 2) + fibo(n - 1);	
	}
	
	return memoization[n];
}
int main() {
	int N;
	cin >> N;
	memoization.resize(N + 1, 0);
	cout << fibo(N);
}
```
