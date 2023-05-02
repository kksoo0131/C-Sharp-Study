BOOL CloseHandle(
  HANDLE hObject
);

//핸들을 닫아 영 체제에서 할당한 자원을 해제하는 역할을 하므로, 핸들을 더 이상 사용하지 않을 때 반드시 호출해야 합니다.
//핸들을 인자로 받으며 성공적으로 닫은경우 TRUE, 닫을수없는경우 FALSE를 반환하고 GetLastError()를 호출해 오류코드를 얻을수 있다.
