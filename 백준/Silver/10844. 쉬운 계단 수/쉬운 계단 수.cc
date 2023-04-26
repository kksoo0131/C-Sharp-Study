#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

//길이 n인 계단수는
// n-1인 계단수에서 수  (마지막수가 0,9이였던 경우 제외)하고 x2해야됨
// 계단수의 마지막수가 뭔지 구조체에 저장
struct stairs {
	string zero = "0";
	string one = "1";
	string two = "1";
	string three = "1";
	string four = "1";
	string five = "1";
	string six = "1";
	string seven = "1";
	string eight = "1";
	string nine = "1";
};

string BigNum(string a, string b) {
	int num = 0;
	string temp;

	while (a.length() != 0 || b.length() !=0 || num != 0) {
		if (a.length() != 0) {
			num += a.back() - '0';
			a.pop_back();
		}

		if (b.length() != 0) {
			num += b.back()-'0';
			b.pop_back();
		}

			temp.push_back(num % 10 + '0') ;
			num /= 10;
		
	}	
	reverse(temp.begin(), temp.end());
	return temp;
}
int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);
	int n;
	cin >> n;
	stairs answer;
	while (--n) {
		stairs temp;
		temp.zero = answer.one;
		temp.one = BigNum(answer.zero,answer.two);
		temp.two = BigNum(answer.one,answer.three);
		temp.three = BigNum(answer.two, answer.four);
		temp.four = BigNum(answer.three , answer.five);
		temp.five = BigNum(answer.four, answer.six);
		temp.six = BigNum(answer.five , answer.seven);
		temp.seven = BigNum(answer.six , answer.eight);
		temp.eight = BigNum(answer.seven, answer.nine);
		temp.nine = answer.eight;
		answer = temp;
	}

	string temp = "0";
	temp = BigNum(temp, answer.zero);
	temp = BigNum(temp, answer.one);
	temp = BigNum(temp, answer.two);
	temp = BigNum(temp, answer.three);
	temp = BigNum(temp, answer.four);
	temp = BigNum(temp, answer.five);
	temp = BigNum(temp, answer.six);
	temp = BigNum(temp, answer.seven);
	temp = BigNum(temp, answer.eight);
	temp = BigNum(temp, answer.nine);
	
	if (temp.length() >= 10) {
		int length = 9;
		

		while (temp[temp.length()-length] == '0') {
			length--;
		}
		temp = temp.substr(temp.length() - length, 9);
	}
		
	cout << temp;

}