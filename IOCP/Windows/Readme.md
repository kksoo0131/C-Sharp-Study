```cpp
HANDLE CreateIoCompletionPort(         // IOCP 핸들(I/O 완료 포트)를 생성하고, ICOP 핸들과 파일 핸들을 연결
  HANDLE    FileHandle,                // I/O를 수행할 파일 핸들
  HANDLE    ExistingCompletionPort,    // 기존 IOCP 핸들 (NULL이면 새 IOCP 생성)
  ULONG_PTR CompletionKey,             // 완료된 I/O작업을 처리하는데 필요한 추가 정보를 제공 (NULL이면 추가정보가 없는것)
  DWORD     NumberOfConcurrentThreads  // 최대 동시 스레드 수 (0 이면 시스템에서 결정)
);

BOOL WINAPI GetQueuedCompletionStatus(     //IOCP 핸들에서 대기중인 I/O 작업의 결과를 검색
  HANDLE       CompletionPort,             //IOCP 핸들
  LPDWORD      lpNumberOfBytesTransferred, //I/O작업의 전송된 바이트 수를 저장할 DWORD포인터
  PULONG_PTR   lpCompletionKey,            //완료된 I/O작업의 CompletionKey를 저장할 ULONG_PTR
  LPOVERLAPPED *lpOverlapped,              //완료된 I/O작업에 연결된 OVERLAPPED구조체의 주소를 저장
  DWORD        dwMilliseconds              //대기시간
);

//HADNLE은 Windows API에서 사용되는 데이터 타입으로, void 포인터의 역할을 하고 여러 정보들을 저장한다.
//ULONG_PTR 부호 없는 정수형 데이터 타입으로, 64비트에서는 8바이트 크기를 가지며, 32비트에서는 4바이트 크기를 가집니다.
//PULONG_PTR ULONG_PTR의 포인터
//DWORD 32비트와 64비트 플랫폼 간의 호환성을 유지하는 4바이트 자료형
```

