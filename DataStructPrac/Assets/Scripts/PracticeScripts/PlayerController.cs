using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 이동 명령 구현 + 이동 명령실행시 `CommandManger`에 명령실행 & 스택 push
    // 되돌리기 누르면 CommandManager의 되돌리기 -> POP 이후 되돌리기 실행
    [SerializeField] private Player _selectedPlayer;
    [SerializeField] private CommandManager _commandManager;
    public PlayerMovement playerMovement;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            MovePlayer(new Vector3(2f, _selectedPlayer.transform.position.y, 0f));
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _commandManager.Undo();
        }
    }
    public void CacheComponents()
    {
       playerMovement = GetComponent<PlayerMovement>();
    }

    private void MovePlayer(Vector3 targetPosition)
    {
        if (_selectedPlayer == null) return;
        ICommand commandable = new PlayerMovement(_selectedPlayer, targetPosition);
        _commandManager.ExecuteCommand(commandable);
    }


    
}
