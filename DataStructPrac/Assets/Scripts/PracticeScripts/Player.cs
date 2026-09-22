using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 위치 변경
    // 추후 여러 기능 추가 가능
    public void PlayerMove(Vector3 position)
    {
        transform.position = position;
    }
}
