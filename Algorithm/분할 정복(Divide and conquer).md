## 분할 정복(Divide and conquer)

 - 그대로 해결할 수 없는 문제를 작은 문제로 분할해서 문제를 해결하는 방법이다. 

## 조건
1. 분할된 하위 문제가 독립적일때 사용한다. (DP와 차이점)

## 방식
1. 분할(Divide) 단계 : 큰 문제를 작은 부분 문제로 나눈다.
2. 정복(Conquer) 단계 : 작은 부분 문제를 해결한다.
3. 합치기(Combine) 단계 : 작은문제의 해답을 이용해 전체 문제의 해답을 구한다.



### 대표적인 예

[4. 퀵 정렬, 최악의 경우 O(N^2)](https://github.com/kksoo0131/Study/blob/main/Algorithm/Sorting/quickSort.cpp)

[5. 병합 정렬.](https://github.com/kksoo0131/Study/blob/main/Algorithm/Sorting/mergeSort.cpp)
