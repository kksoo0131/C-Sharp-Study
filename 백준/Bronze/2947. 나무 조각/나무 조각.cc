#include <iostream>
#include <string>
#include<vector>

using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);

	int N = 5;
	vector<int> list(N);

	while (N--) {
		cin >> list[4 - N];
	}

	int isSort = 0;
	while (true) {

		for (int i = 0; i < 4; i++) {
            //각 자리를 비교하면서 교체
            //한번도 교체가 일어나지 않으면 정렬됬다는 뜻
			if (list[i] > list[i + 1]) {
				swap(list[i], list[i + 1]);

				for (int k : list) {
					cout << k << " ";
				}
				cout << '\n';
			}
			else {
				isSort++;
			}
		}

		if (isSort == 4)
			break;
		
		isSort = 0;
	}
	

}