ClientInfo* GetEmptyClientInfo()
{
  for(auto& client : _clientInfos)
  {
    if(INVALID_SOCKET == client._socketClient)
    {
      return &client;
    }
  }
  return nullptr;
}

//_clientInfos에서 빈 클라이언트 소켓을 찾아서 반환한다.
