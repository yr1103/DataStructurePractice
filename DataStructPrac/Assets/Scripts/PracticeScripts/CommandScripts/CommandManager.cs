using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    // 명령 스택에 담기
    private Stack<ICommand> moveStack = new Stack<ICommand>();
    
    // 명령 실행
    public void ExecuteCommand(ICommand commandable)
    {
        commandable.Execute();
        moveStack.Push(commandable);
    }
    
    // 되돌리기
    public void Undo()
    {
        // 스택이 비어있으면
        if (moveStack.Count <= 0)
        {
            Debug.Log("Nothing to undo");
            return;
        }
     
        ICommand commandable = moveStack.Pop();
        commandable.Undo();
    }
}
