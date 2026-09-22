using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private HashSet<float> _hashSet = new();
    
    // Start is called before the first frame update
    void Start()
    {
        _hashSet.Add(5f);
        _hashSet.Add(3.5f);
        _hashSet.Add(2.6f);
        _hashSet.Add(90.5f);
        
        if(_hashSet.Contains(5f)) Debug.Log("5f 들어있음");
        
        Debug.Log(_hashSet.Count);

    }

}

// private Stack<Action> _actionStack = new();