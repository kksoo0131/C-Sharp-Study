#include <winsock2.h>

bool WinsockInit(){
 WSADATA _wsadata;
 int result = WSAStartup((2,2), &wsadata);
  
  if(result != 0){
    print("result가 0이 아니라면 실패");
    return false;
  }
 
}
 
