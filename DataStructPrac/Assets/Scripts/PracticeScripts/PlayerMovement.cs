using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, ICommand
{
    private Player _player;
    private Vector3 _prevPosition;
    private Vector3 _targetPosition;


    public PlayerMovement(Player player, Vector3 targetPosition)
    {
        this._player = player;  // 플레이어
        this._prevPosition = player.transform.position; // 이전 위치 저장
        this._targetPosition = targetPosition;  // 목표지점 저장
    }
    // Player.cs
    // private void PlayerMove(Vector3 position)
    // {
    //     transform.position = position;
    // }

    
    // 실행시 플레이어 이동
    public void Execute()
    {
        _player.PlayerMove(_targetPosition);
    }

    // 되돌리기시 저장했던 위치로 돌아오기
    public void Undo()
    {
        _player.PlayerMove(_prevPosition);
    }
    
}
