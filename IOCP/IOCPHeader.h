#pragma once
#pragma comment(lib, "ws2_32")
#include <winsock2.h>
#include <Ws2tcpip.h>

#include<thread>
#include<vector>

#define MAX_SOCKBUF 1024
#define MAX_WORKERTHREAD 4
