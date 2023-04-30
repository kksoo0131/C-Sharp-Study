struct sockaddr_in {
    short   sin_family;           // 주소체계 (주로 AF_INET)
    u_short sin_port;           // 16비트 TCP/UDP 포트 번호
    struct  in_addr sin_addr;    // 32비트 IP 주소
    char    sin_zero[8];           // 사용되지 않음
};

void ServerAddrSetting(int BindPort){
  sockaddr_in _serverAddr;
  _serverAddr.sin_family = AF_INET;
  _serverAddr.sin_port = htons(BindPort);
  _serverAddr.sin_addr.s_addr = htonl(INADDR_ANY);
  
  // INADDR_ANY 어떤주소라도 접속을 받아들이겠다라는 의미.
}
