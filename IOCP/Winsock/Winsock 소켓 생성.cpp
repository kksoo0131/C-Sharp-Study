#include <winsock2.h>

SOCKET _listenSocket = INVALID_SOCKET;

void CreateSocket(){
  _listenSocket = WSASocket(AF_INET, SOCK_STREAM, IPPROTO_TCP, NULL, NULL, WSA_FLAG_OVERLAPPED);
  if (INVALID_SOCKET == _listenSocket) {
    printf("소켓 생성에 실패 : %d\n", WSAGetLastError());
    return false;
  }
}
