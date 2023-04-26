#include <iostream>
#include <algorithm>

using namespace std;


int n;
int triangle[500][500] = {-1};
int main() {
	cin >> n;
	cin >> triangle[0][0];
	for (int i = 1; i < n; i++) {
		for (int j = 0; j <= i; j++) {
			int temp;
			cin >> temp;
			//triangle[i-1][j-1] 과 triangle[i-1][j]를 확인해야됨
			if (j - 1 < 0)
				triangle[i][j] = temp + triangle[i - 1][j];
			else if (triangle[i-1][j] == -1)
				triangle[i][j] = temp + triangle[i - 1][j-1];
			else {
				triangle[i][j] = max(
					temp + triangle[i - 1][j],
					temp + triangle[i - 1][j - 1]);
			}
		}
	}

	int max_value = *max_element(triangle[n - 1], triangle[n - 1]+n);
	cout << max_value;
}
