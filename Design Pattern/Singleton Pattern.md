<h2>Singleton Pattern</h2>
      
    싱글톤 패턴은 클래스 내부에 해당 클래스의 인스턴스를 static으로 선언, 메모리를 정적으로 할당하여
    하나의 객체에만 접근하는 방법 - 데이터를 전역으로 관리할수있다.
    객체를 새로 선언을 하더라도 이미 정적으로 선언된 객체가 반환(중복 생성을 방지)
    (그냥 정적 클래스와의 차이는?)
     정적 클래스는 객체를 아예 생성할수 없고, static 메소드와 함수를 가진 네임스페이스와 비슷한 역할을 하게됨
     싱글톤 패턴은 객체를 생성할수 있고 그 내부에있는 static으로 선언된 객체를 모두 공유하게된다.
    
  <h4>Unity</h4>

```unity
using UnityEngine;

public class Managers : MonoBehaviour
{
  static Managers s_instance; // 정적 객체 선언
  public static Managers Instance { get { Init(); return s_instance; } }
  
  static void Init()
  {
    if(s_instance == null)
    {
      GameObject go = GameObject.Find("@Managers");
      if(go == null)
      {
        go = new GameObject {name = "@Managers"};
        go.AddComponent<Managers>();
      }
      s_instance = go.GetComponent<Managers>();
     }
  }
}
```

  <h4>C#</h4>

```cs
public class Singleton
{
  static Singleton s_singleton;

  public static Singleton Instace 
  {
    get{
      if (s_singleton == null)
      {
        s_singleton = new Singleton();
      }
      return s_singleton;} 
   }
}
  

```
