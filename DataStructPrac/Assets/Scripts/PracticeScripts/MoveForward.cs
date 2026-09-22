using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 5.0f;
    
    private void Update()
    {
        gameObject.transform.Translate(Vector3.forward * Time.deltaTime *  _moveSpeed);
    }
}
