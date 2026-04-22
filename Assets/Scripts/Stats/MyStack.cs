using UnityEngine;

public class MyStack <T>
{
    #region Privates
    private StackNode<T> top;
    private int count;
    #endregion
    #region Public Methods
    public void Push(T value)
    {
        StackNode<T> newNode = new StackNode<T>(value);
        //-> caso pila vacia
        if(top == null)
        {
            top = newNode;
            count++;
            return;
        }
        //->pila ya tiene un elemento
        newNode.SetNext(top);
        top=newNode;
       
        count++;
    }
    public T Pop()
    {
        if (top == null) //return default; //-> verificar si lista esta vacia
            throw new System.Exception("Trying to Pop");
        T tempValue = top.Value;//-> referencia 
        top = top.Next;
        count--;

        return tempValue;
    }
    public T Peek()
    {
        if (top == null) //return default;
        throw new System.Exception("Trying to peek a empty stack");

        T tempValue = top.Value;
        return tempValue;
    }
    public void Clear()
    {
        top= null;
        count = 0;
    }
    #endregion
    #region Getters
    public StackNode<T> Top => top;
    public int Count => count;
    #endregion
}
