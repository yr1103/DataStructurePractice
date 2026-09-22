// ---1단계--------------------------------------------

public class MyList<T>  
{  
    private T[] _items;  
    private int _count;    

    public int Count  
    {  
        get { return _count; }  
    }

    public int Capacity  
    {  
        get { return _items.Length; }  
    }

    public MyList()  
    {  
        // 칸이 하나도 없는 배열을 만들어 _items에 담습니다. 첫 Add에서 칸이 생깁니다.  
        _items = new T[0];
    }

    public MyList(int capacity)  
    {  
        // 넘겨받은 칸 수만큼의 배열을 만들어 _items에 담습니다.  
        _items = new T[capacity];
        
    }

    // O(?) - n은 1 => Index로 접근
    public T Get(int index)  
    {  
        // index 칸의 값을 돌려줍니다.  
        return (_items[index]);  
    }

    // O(?) - n은 1 => Get과 동일하게 Index로 바로 접근
    public void Set(int index, T value)  
    {  
        // index 칸에 value를 넣습니다.  
        _items[index] = value;  
    }

    public string ToText()  
    {  
        string text = "";

        for (int i = 0; i < _count; i++)  
        {  
            if (i > 0)  
            {  
                text += ", ";  
            }

            text += _items[i];  
        }
        
        return text;  
    }  
    
    // ---2단계---------------------------------------
    
    // O(?) - 추가할 공간이 있으면 O(1), 배열 꽉 찼으면 O(n) (GrowIfFull()에서 칸 수만큼의 배열을 새로 만들기에)
    public void Add(T value)
    {
        // 칸이 다 찼으면 먼저 칸을 늘립니다.
        if (_count >= Capacity)
        {
            GrowIfFull();
        }
        // 개수가 가리키는 칸에 value를 넣습니다.
        _items[_count] = value;
        // 개수를 하나 늘립니다. 
        _count++;
    }

    // O(?) - O(n) -> 맨 앞에서 삽입할 경우 n개만큼 전부 이동해야함.
    public void Insert(int index, T value)  
    {  
        // 칸이 다 찼으면 먼저 칸을 늘립니다.  
        if (_count >= Capacity)
        {
            GrowIfFull();
        }
        // 맨 끝 요소부터 index 자리의 요소까지, 뒤에서부터 돌며 한 칸씩 뒤로 옮깁니다.  
        for (int i = _count-1; i >= index; i--) //끝부터 index까지
        {
            _items[i + 1] = _items[i]; // 하나씩 뒤로
        }
        // index 칸에 value를 넣습니다.  
        _items[index] = value;
        // 개수를 하나 늘립니다.  
        _count++;
    }

    // O(?) - O(1) = 공간이 남아 있는 경우 return / O(n) 배열 확장시 n개 만큼 새 배열로 복사
    private void GrowIfFull()  
    {  
        T[] newItems;
        int newCapacity; 
        // 개수가 칸 수보다 작으면 아무것도 하지 않고 돌아갑니다.  
        if (_count < Capacity) return;
        // 새 칸 수를 정합니다. 지금 칸 수가 0이면 4, 아니면 지금 칸 수의 두 배입니다.  
        newCapacity = (Capacity == 0 ? 4 :2 * _items.Length);   // if/else 대신 삼항연산자로 처리
        // 새 칸 수만큼의 배열을 새로 만듭니다.  
        newItems = new T[newCapacity];
        // 담긴 요소를 앞에서부터 새 배열의 같은 번호 칸에 옮겨 담습니다.  
        for(int i=0; i< _count; i++)
        {
            newItems[i] = _items[i];
        }
        // _items가 새 배열을 가리키게 합니다.  
        _items = newItems;
    }
    
    
    // ---3단계---------------------------------------
    
    // O(?) - n은 ...
    public int IndexOf(T value)  
    {  
        // 0번 칸부터 개수 직전 칸까지 앞에서부터 차례로 돕니다.  
        // 그 칸의 값이 value와 같은 값이면 그 번호를 돌려줍니다.  
        // 끝까지 돌아도 같은 값이 없으면 -1을 돌려줍니다.  
        return -1;  
    }

    // O(?) - n은 ...
    public bool Contains(T value)  
    {  
        // value가 몇 번 자리에 있는지 찾습니다.  
        // 찾은 번호가 0보다 작지 않으면 들어 있는 것입니다.  
        return false;  
    }

    // O(?) - n은 ...
    public void RemoveAt(int index)  
    {  
        // index 다음 요소부터 맨 끝 요소까지, 앞에서부터 돌며 한 칸씩 앞으로 옮깁니다.  
        // 개수를 하나 줄입니다.  
        // 비어 버린 맨 뒷자리 칸을 기본값으로 바꿉니다.  
    }

    // O(?) - n은 ...
    public bool Remove(T value)  
    {  
        // value가 몇 번 자리에 있는지 찾습니다.  
        // 찾지 못했으면 false를 돌려줍니다.  
        // 찾았으면 그 자리를 지우고 true를 돌려줍니다.  
        return false;  
    }

    // O(?) - n은 ...
    public void Clear()  
    {  
        // 0번 칸부터 개수 직전 칸까지 차례로 돌며 기본값으로 바꿉니다.  
        // 개수를 0으로 만듭니다.  
        // 칸 수는 건드리지 않습니다.  
    }
}


