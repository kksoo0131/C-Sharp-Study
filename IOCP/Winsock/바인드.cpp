bool Bind(int BindPort){
  SOCKADDR_IN _serverAddr;
  _serverAddr.sin_family = AF_INET;
  _serverAddr.sin_port = htons(BindPort);
  _serverAddr.sin_addr.s_addr = htonl(INADDR_ANY);
 
  int result = bind(_listenSocket, (SOCKADDR*)&_serverAddr, sizeof(SOCKADDR_IN));
  
  if (result != 0){
    printf("결과가 0이 아니라면 실패 : %d\n", WSAGetLastError());
    return false;
  }
}
