int bind(SOCKET s, const struct sockaddr* name, int namelen);

bool Bind(){
  int result = bind(_listenSocket, (SOCKADDR*)&_serverAddr, sizeof(SOCKADDR_IN));
  
  if (result != 0){
    printf("결과가 0이 아니라면 실패 : %d\n", WSAGetLastError());
    return false;
  }
}
