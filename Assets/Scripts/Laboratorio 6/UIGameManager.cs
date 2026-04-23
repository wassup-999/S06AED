using Sirenix.OdinInspector;
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIGameManager : MonoBehaviour
{
    public InputSystem_Actions inputs;
    public WindowManager wmanager = new();

    private void Awake()
    {
        inputs = new();
    }
    private void OnEnable()
    {
        inputs.Enable();
        inputs.UI.Escape.performed += HideCurrentPanel;
        //inputs.UI.Escape.canceled += HideCurrentPanel;
        wmanager.OnElementAdded += OnElementAdded;
        wmanager.OnElementRemoved += OnElementRemoved;
    }
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    
    private void OnElementAdded(Window window)
    {
        window.window.SetActive(true);
        window.window.transform.SetSiblingIndex(3);        
        Debug.Log("Activado");
        

    }

    private void OnElementRemoved(Window window)
    {            
        window.window.SetActive(false);
        //window.window.transform.SetAsFirstSibling();
 
        Debug.Log("Desactivado");
        
        
    }
    private void HideCurrentPanel(InputAction.CallbackContext context)
    {       
        while(wmanager.Count > 0 && wmanager.Peek().window.activeSelf == true )
        {
            wmanager.Pop();
        }
        
        //wmanager.Pop();
        

    }

    public void BtnOpenPanel(GameObject panel)
    {
        Window window = new(panel);
        wmanager.Push(window);
    }
    [Button]
    public void PeekFromStack()
    {
        Debug.Log(wmanager.Peek().window.name);
    }
    [Button]
    public void Count() => Debug.Log(wmanager.Count);
}
