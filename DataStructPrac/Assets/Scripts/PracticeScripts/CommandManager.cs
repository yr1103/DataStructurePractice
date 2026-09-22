using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    private Stack<ICommandable> moveStack = new Stack<ICommandable>();
    
    public void ExecuteCommand(ICommandable commandable)
    {
        commandable.Execute();
        moveStack.Push(commandable);
    }

    public void Undo()
    {
        if (moveStack.Count == 0)
        {
            Debug.Log("Nothing to undo");
            return;
        }
     
        ICommandable commandable = moveStack.Pop();
        commandable.Undo();
    }

}
