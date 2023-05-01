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

