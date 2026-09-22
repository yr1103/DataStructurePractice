using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColliderMove : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject go = new GameObject();
        go.AddComponent<MoveForward>();
    }
}
