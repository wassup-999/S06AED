using UnityEngine;
using Sirenix.OdinInspector;
public class GameManager : MonoBehaviour
{
    public MyStack<string> namesStack = new();
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    [Button]
    public void PushToStack(string value)
    {
        namesStack.Push(value);
    }
    [Button]
    public void PopFromStack()
    {
        Debug.Log(namesStack.Pop());
    }
    [Button]
    public void PeekFromStack()
    {
        Debug.Log(namesStack.Peek());
    }
    [Button]
    public void ClearStack()
    {
        namesStack.Clear();
    }
    [Button]
    public void Count() => Debug.Log(namesStack.Count);
}
