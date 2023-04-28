# IOCP - Input/Output Completion Port

  Microsoft Windows 운영체제에서 비동기 I/O작업을 처리하기 위한 메커니즘
  

1. OverlappedI/O : 비동기 I/O작업을 수행하는 데 사용되는 Windows API

2. CompletionQueue : 비동기 I/O작업의 결과를 관리하는 대기열, 작업이 완료되면 결과를 큐에 넣어둔다.

3. ThreadPool : 작업 스레드를 미리 만들어놓고 대기열에 있는 작업을 스레드를 할당하여 처리한다.

        수행된 비동기 작업들을 Queue와 ThreadPool을 사용하여 오버헤드 없이 효율적으로 처리한다.
        
        (오버헤드 - 작업을 처리하는 데 들어가는 추가적인 비용이나 시간)
	
	
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

[Winsock2.h](https://github.com/kksoo0131/Study/blob/main/IOCP/Winscock2.md)



-std::thread

```cpp
// joinable() 스레드 객체의 상태를 확인하는 함수, join()함수를 호출 할 수 있는지 여부를 반환 할수없다면 true

// join() 호출된 스레드가 종료될 때까지 대기하는 함수, 레드가 종료될 때까지 현재 스레드가 대기하다 반환된다.
// 스레드가 종료되기 전까지 다른곳에서 사용할 수 없게한다.

```
      
- 에러코드 관련

      GetLastError() - Windows 운영 체제에서 발생한 오류 코드를 가져오는 함수 ( windows.h) 
      WSAGetLastError() - Winsock.h 라이브러리에서 발생한 오류코드를 가져오는 함수 ( winsock2.h)
      ERROR_IO_PENDING - 비동기 작업이 아직 완료되지 않았다는 것을 나타내는 에러코드
