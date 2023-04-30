#define MAX_WORKERTHREAD 4 //쓰레드 풀에 넣을 쓰레드 수

HADNLE _IOCPHandle = INVAILD_HANDLE_VALUE;

bool CreateIOCPHandle()
{
  _IOCPHandle = CreateIoCompletionPort(INVAILD_HANDLE_VALUE, NULL, NULL, MAX_WORKERTHREAD);
  if(NULL == _IOCPHandle)
  {
    printf("_IOCPHandle가 NULL이라면 생성 실패 %d\n", GetLastError());
    return false;
  }  
}

// Windows.h 라이브러리에 포함
HANDLE CreateIoCompletionPort(         // IOCP 핸들(I/O 완료 포트)를 생성하고, ICOP 핸들과 파일 핸들을 연결
  HANDLE    FileHandle,                // I/O를 수행할 파일 핸들
  HANDLE    ExistingCompletionPort,    // 기존 IOCP 핸들 (NULL이면 새 IOCP 생성)
  ULONG_PTR CompletionKey,             // 완료된 I/O작업을 처리하는데 필요한 추가 정보를 제공 (NULL이면 추가정보가 없는것)
  DWORD     NumberOfConcurrentThreads  // 최대 동시 스레드 수 (0 이면 시스템에서 결정)
);
//HADNLE은 Windows API에서 사용되는 데이터 타입으로, void 포인터의 역할을 하고 여러 정보들을 저장한다.
//ULONG_PTR 부호 없는 정수형 데이터 타입으로, 64비트에서는 8바이트 크기를 가지며, 32비트에서는 4바이트 크기를 가집니다.
//PULONG_PTR ULONG_PTR의 포인터
//DWORD 32비트와 64비트 플랫폼 간의 호환성을 유지하는 4바이트 자료형
