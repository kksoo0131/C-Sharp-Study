#include <iostream>
using namespace std;
int fibo(int n) {
    if (n == 0 || n == 1)
        return n;
    return fibo(n - 2) + fibo(n - 1);
}
int main() {
    ios::sync_with_stdio(false);
    cin.tie(0), cout.tie(0);
    int N;
    cin >> N;
    cout << fibo(N);
}