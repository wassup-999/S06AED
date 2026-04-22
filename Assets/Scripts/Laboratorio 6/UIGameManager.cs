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
            
    }

    private void OnElementRemoved(Window window)
    {
        window.window.SetActive(false);
    }
    private void HideCurrentPanel(InputAction.CallbackContext context)
    {
        
    }

    public void BtnOpenPanel(GameObject panel)
    {
        Window window = new(panel);
        wmanager.Push(window);
    }
}
