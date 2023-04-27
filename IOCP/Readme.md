# IOCP - Input/Output Completion Port

  Microsoft Windows 운영체제에서 비동기 I/O작업을 처리하기 위한 메커니즘
  

1. OverlappedI/O : 비동기 I/O작업을 수행하는 데 사용되는 Windows API

2. CompletionQueue : 비동기 I/O작업의 결과를 관리하는 대기열, 작업이 완료되면 결과를 큐에 넣어둔다.

3. ThreadPool : 작업 스레드를 미리 만들어놓고 대기열에 있는 작업을 스레드를 할당하여 처리한다.

        수행된 비동기 작업들을 Queue와 ThreadPool을 사용하여 오버헤드 없이 효율적으로 처리한다.
        
        (오버헤드 - 작업을 처리하는 데 들어가는 추가적인 비용이나 시간)
	
	
		htons()
		htonl()
		closesocket()
		joinalbe()
		join()
		C++ 람다식
		struct linger
		SD_BOTH
		SOL_SOCKET
		SO_LINGER
		shutdown()
		setsockopt()

- WinSock2.h

```cpp
struct sockaddr_in {
    short   sin_family;           // 주소체계 (주로 AF_INET)
    u_short sin_port;           // 16비트 TCP/UDP 포트 번호
    struct  in_addr sin_addr;    // 32비트 IP 주소
    char    sin_zero[8];           // 사용되지 않음
};

SOCKET WSASocket(                     //소켓 객체 생성
  int                af,              //주소체계 AF_INET, AF_INET6
  int                type,            //소켓 유형 SOCK_STREAM, SOCK_DGRAM 
  int                protocol,        //프로토콜 IPPROTO_TCP, IPPROTO_UDP
  LPWSAPROTOCOL_INFO lpProtocolInfo,  //프로토콜 정보 NULL
  GROUP              g,               //멀티캐스트 소켓 그룹 0
  DWORD              dwFlags          //옵션을 지정 (WSA_FLAG_OVERLAPPED 비동기식 소켓 생성)
);

int WSARecv(                                              // 비동기 IO recv
  SOCKET                             s,                   // 소켓 핸들(소켓의 유일한 식별자)
  LPWSABUF                           lpBuffers,           // 버퍼 배열
  DWORD                              dwBufferCount,       // 버퍼 배열의 원소 개수
  LPDWORD                            lpNumberOfBytesRecvd,// 받을 데이터의 크기
  LPDWORD                            lpFlags,             // 옵션을 지정
  LPWSAOVERLAPPED                    lpOverlapped,        // 비동기I/O를 위한 OVERLAPPED구조체 작업 정보를 저장
  LPWSAOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine  // 비동기I/O작업 완료 후 호출된 콜백 함수 (NULL인경우 블로킹)
);

int WSASend(                                              // 비동기 IO send
  SOCKET                             s,                   // 소켓 핸들(소켓의 유일한 식별자)
  LPWSABUF                           lpBuffers,           // 버퍼 배열
  DWORD                              dwBufferCount,       // 버퍼 배열의 원소 개수
  LPDWORD                            lpNumberOfBytesSent, // 실제로 전송할 데이터의 크기
  DWORD                              dwFlags,             // 옵션을 지정
  LPWSAOVERLAPPED                    lpOverlapped,        // 비동기I/O를 위한 OVERLAPPED구조체 작업 정보를 저장
  LPWSAOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine  // 비동기I/O작업 완료 후 호출될 콜백 함수 (NULL인경우 블로킹)
);
//WSAOVERLAPPED는 비동기 소켓 입출력 작업에서 사용되는 구조체, 입출력 작업을 지시하고 작업이 완료될 때 정보를 제공.




```
- Windows.h

```cpp
//HADNLE은 Windows API에서 사용되는 데이터 타입으로, void 포인터의 역할을 하고 여러 정보들을 저장한다.
//ULONG_PTR 부호 없는 정수형 데이터 타입으로, 64비트에서는 8바이트 크기를 가지며, 32비트에서는 4바이트 크기를 가집니다.
//PULONG_PTR ULONG_PTR의 포인터
//DWORD 32비트와 64비트 플랫폼 간의 호환성을 유지하는 4바이트 자료형

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
```
      
- 에러코드 관련

      GetLastError() - Windows 운영 체제에서 발생한 오류 코드를 가져오는 함수 ( windows.h) 
      WSAGetLastError() - Winsock.h 라이브러리에서 발생한 오류코드를 가져오는 함수 ( winsock2.h)
      ERROR_IO_PENDING - 비동기 작업이 아직 완료되지 않았다는 것을 나타내는 에러코드
