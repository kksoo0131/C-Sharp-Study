#include <winsock2.h>

// winsock2.h에 포함
SOCKET WSASocket(                     //소켓 객체 생성
  int                af,              //주소체계 AF_INET, AF_INET6
  int                type,            //소켓 유형 SOCK_STREAM, SOCK_DGRAM 
  int                protocol,        //프로토콜 IPPROTO_TCP, IPPROTO_UDP
  LPWSAPROTOCOL_INFO lpProtocolInfo,  //프로토콜 정보 NULL
  GROUP              g,               //멀티캐스트 소켓 그룹 0
  DWORD              dwFlags          //옵션을 지정 (WSA_FLAG_OVERLAPPED 비동기식 소켓 생성)
);

SOCKET _listenSocket = INVALID_SOCKET;

void CreateSocket(){
  _listenSocket = WSASocket(AF_INET, SOCK_STREAM, IPPROTO_TCP, NULL, NULL, WSA_FLAG_OVERLAPPED);
  if (INVALID_SOCKET == _listenSocket) {
    printf("소켓 생성에 실패 : %d\n", WSAGetLastError());
    return false;
  }
}
