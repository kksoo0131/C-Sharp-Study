#include <vector>
#include <thread>

#define MAX_WORKERTHREAD 4 // 쓰레드 풀에 넣을 쓰레드 수

std::vector<std::thread> _IOWorkerThreads;
std::thread _AccepterThread;
_isWorkerRun = true;

//WaitingThread Queue에 대기 상태로 넣을 쓰레드 생성 권장 개수 : cpu개수 *2+1
void CreateWorkerThread()
{
  unsigned int uiThreadId = 0;
  
  for (int i=0; i< MAX_WORKERTHREAD; i++)
  {
    _IOWorkerThreads.emplace_back( [this](){WorkerThread(); });
  }
}

void WorkerThread()
{
  ClientInfo* pClientInfo = nullptr;  // CompletionKey를 받을 포인터 변수
  BOOL bSuccess = TRUE;               // 함수 호출 성공 여부
  DWORD dwIoSize = 0;                 // Overlapped I/O작업에서 전송된 데이터 크기
  OVERLAPPED* lpOverlapped = nullptr; // I/O 작업을 위해 요청한 Overlapped 구조체를 받을 포인터
  
  while (_isWorkerRun)
  {
      ///////////////////////////////////////////////////////
			//이 함수로 인해 쓰레드들은 WaitingThread Queue에      //
			//대기 상태로 들어가게 된다.                           //
      //                                                   //
			//완료된 Overlapped I/O작업이 발생하면 IOCP Queue에서  //
			//완료된 작업을 가져와 뒤 처리를 한다.                  //
      //                                                   //
			//그리고 PostQueuedCompletionStatus()함수에의해 사용자 //
			//메세지가 도착되면 쓰레드를 종료한다.                  //
			///////////////////////////////////////////////////////
    
    bSuceess = GetQueueCompletionStatus(_IOCPHandle,
                                       &dwIoSize,
                                       (PULONG_PTR)&pClientInfo,
                                       &lpOverlapped,
                                       INFINITE);
    
  }
}
