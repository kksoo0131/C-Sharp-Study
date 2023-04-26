#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

//길이 n인 오르막수는
// n-1인 오르막수의 마지막수 x (10 - 끝자리수)개 만들수있다

unsigned long long arr[10] = {1,1,1,1,1,1,1,1,1,1};

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);
	int n;
	cin >> n;
	int answer =10;

	while (--n) {
		unsigned long long temp[10]={0};
		answer = 0;
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j <= i; j++) {
				temp[i] += arr[j] % 10007;
			}
		}
		
		for (int i = 0; i < 10; i++) {
			arr[i] = temp[i];
			answer += arr[i];
			answer %= 10007;
		}
	}
	cout << answer;

}