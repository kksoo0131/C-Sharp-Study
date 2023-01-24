<h2>Lambda</h2>  

<h4>함수 선언 없이 함수를 사용하는 문법</h4>

<h5>ex 1 ) 람다식을 일회용함수로 사용하는 방법 </h5>

```cs
class Item
    {
        public int ItemType;
        public int Rarity;
    }

    class Program
    {
        static List<Item> _items = new List<Item>();
        
        //인자를 Item 타입으로 하나받고 bool값을 return하는 delegate를 정의
        delegate bool ItemSelector(Item item);

        // delegate로 정의된 ItemSelector에 해당하는 함수를 인자로 받는 함수
        static Item FindItem(ItemSelector selector)
        {
            foreach (Item item in _items) 
            {
                if (item.ItemType == 3)
                    return item;
            }
            return null;
        }

        static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = 1, Rarity = 2 });
            _items.Add(new Item() { ItemType = 2, Rarity = 4 });
            _items.Add(new Item() { ItemType = 3, Rarity = 6 });
        }
        // Anonymous Fuction :무명/익명 함수를 이용해서 일회용 함수를 사용해서 인자로 넣어줬음
        Item item = FindItem(delegate (Item item) { return item.ItemType == 3; });
        // Lambda : 무명 함수를 개선한 버젼
        Item item2 = FindItem((Item item) => { return item.ItemType == 3; });

    }
```

<h5>ex 2 ) delegate 객체를 만들어 람다식을 재사용 하는 방법 </h5>

```cs
class Item
    {
        public int ItemType;
        public int Rarity;
    }

    class Program
    {
        static List<Item> _items = new List<Item>();
        
        //인자를 Item 타입으로 하나받고 bool값을 return하는 delegate를 정의
        delegate bool ItemSelector(Item item);

        // delegate로 정의된 ItemSelector에 해당하는 함수를 인자로 받는 함수
        static Item FindItem(ItemSelector selector)
        {
            foreach (Item item in _items) 
            {
                if (item.ItemType == 3)
                    return item;
            }
            return null;
        }

        static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = 1, Rarity = 2 });
            _items.Add(new Item() { ItemType = 2, Rarity = 4 });
            _items.Add(new Item() { ItemType = 3, Rarity = 6 });
            
            // delegate객체를 생성할때 람다식을 이용해서만들어 재사용하는 방법이다.
            ItemSelector selector = (Item item) => { return item.ItemType == 3;};
            Item item = FindItem(selector);
        }
       

    }

```

<h2>Action<T> & Func<T,TResult></h2>  

<h4>0~16개의 매개변수를 받을 수 있게 미리 선언 되어 있는 delegate들 이다.</h4>
<h5>반환 타입이 있을 경우 Func, 없을 경우 Action을 사용한다</h5>
 
 <h5>ex )</h5>

```cs
class Item
  {
      public int ItemType;
      public int Rarity;
  }

  class Program
  {
      static List<Item> _items = new List<Item>();

      static Item FindItem(Func<Item, bool> selector)
      {
          foreach (Item item in _items) 
          {
              if (item.ItemType == 3)
                  return item;
          }
          return null;
      }

      static void Main(string[] args)
      {
          _items.Add(new Item() { ItemType = 1, Rarity = 2 });
          _items.Add(new Item() { ItemType = 2, Rarity = 4 });
          _items.Add(new Item() { ItemType = 3, Rarity = 6 });

          // delegate객체를 생성할때 람다식을 이용해서만들어 재사용하는 방법이다.
          Func<Item, bool> selector = (Item item) => { return item.ItemType == 3;};
          Item item = FindItem(selector);
      }


  }

```
 
