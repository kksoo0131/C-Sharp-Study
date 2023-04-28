## WinSock2.h
[이전페이지](https://github.com/kksoo0131/Study/blob/main/IOCP/Readme.md)
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

//htons() unsigned short 
//htonl() unsigned long
//다양한 플랫폼과 네트워크 환경에서 호환성을 유지하기 위해서 Big-endian으로 변경해준다.
//대부분의 네트워크 장비들은 Big-endian방식을 사용하고, 일반적인 컴퓨팅 환경은 Little-endian방식을 사용한다.

//closesocket() 소켓을 닫는 함수, 해당 소켓이 사용 중이던 리소스가 반환되고, 모든 연결도 끊어진다.
//소켓을 닫지 않아 소켓이 계속해서 포트를 점유하고 있게되면, 다른 소켓이 같은 포트를 사용하지 못하게되고, 메모리 누수가 발생할수 있어
// 명시적으로 닫아주는것이 권장된다.

// shutdown() 소켓의 한쪽 연결을 종료하는 함수, 소켓의 입출력에 대한 방향을 지정하여, 소켓과 연결된 상대측과의 통신을 종료
// 첫번쨰 인자 종료할 소켓을 지정
// 두번쨰 인자 방향을 지정 SD_SEND, SD_RECEIVE, SD_BOTH

// setsockopt() 소켓 옵션을 설정하는데 사용된다.
// 첫번째 인자 소켓을 지정
// 두번쨰 인자 설정하려는 옵션의 범위를 지정, 보통 SOL_SOCKET
// 세번쨰 인자 옵션의 이름을 지정, SO_LINGER (TCP소켓을 닫을 때 바로 close되지 않고 일정 시간만큼 지연되어 버퍼에 남은 데이터를 전송하고 소켓을 닫는다)
// 네번쨰 인자는 설정하려는 옵션에 대한 값 (일정 시간을 정해준다.)

struct linger {	  //TCP 소켓의 연결을 끊을때 지연 시간을 설정 할 수 있는 구조체
    int l_onoff;  // 지연 시간 사용 여부 (0: 끄기, !=0: 켜기)
    int l_linger; // 지연 시간 값 (초 단위)
};
 
