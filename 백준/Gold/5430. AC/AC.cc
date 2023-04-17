#include <iostream>
#include <deque>
#include <string>
#include <algorithm>
using namespace std;

int main() {
	cin.tie(0), cout.tie(0), ios::sync_with_stdio(false);
	int T;
	cin >> T;
	while (T--) {
		string str; cin >> str;
		int N; cin >> N;
		string arr; cin >> arr;
		// 반례1. 숫자 자릿수 3자리까지받기
		// 반례2. 공백넣으면 괄호만 출력
		// 3. 시간초과 reverse 사용하지말고 뒤집었는지만 체크
		deque<int> dq;
		bool error = false;
		int reverse = 0;
		int temp = 0;
		for (char c : arr) {
			if (c == '[') {
				continue;
			}
			else if (c == ']' && temp != 0) {
				dq.push_back(temp);
			}
			else if (c == ',') {
				dq.push_back(temp);
				temp = 0;
			}
			else {
				if(temp == 0) 
					temp += c - 48;
				else if (temp > 0) {
					temp *= 10;
					temp += c - 48;
				}
					
			}
		}
		
		for (char c : str) {
			if (c == 'R') {
				reverse += 1;
			}
			else {
				if (dq.empty()) {
					error = true;
					break;
				}
				else {
					if (reverse % 2 ==1)
						dq.pop_back();
					else
						dq.pop_front();
				}
					
			}

		}
		if (reverse % 2 == 1)
			std::reverse(dq.begin(), dq.end());
		if (error)
			cout << "error" << '\n';
		else {
			cout << "[";
			if (dq.size() > 0) {
				for (int i = 0; i < dq.size() - 1; i++) {
					cout << dq[i] << ",";
				}

				cout << dq.back();
			}
			
			cout << "]" << '\n';
		}


		
	}
}