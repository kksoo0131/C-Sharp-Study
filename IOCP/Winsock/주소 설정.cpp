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
}
// INADDR_ANY 어떤주소라도 접속을 받아들이겠다라는 의미.
  
//htons() unsigned short 
//htonl() unsigned long
//다양한 플랫폼과 네트워크 환경에서 호환성을 유지하기 위해서 Big-endian으로 변경해준다.
//대부분의 네트워크 장비들은 Big-endian방식을 사용하고, 일반적인 컴퓨팅 환경은 Little-endian방식을 사용한다.

