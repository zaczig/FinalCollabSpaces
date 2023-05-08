using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIManager : MonoBehaviour
{
    public InputActionProperty primaryButton;
    public GameObject menu;

    // Update is called once per frame
    void Update()
    {
        bool isPrimaryPressed = primaryButton.action.WasPressedThisFrame();
        if (isPrimaryPressed)
        {
            menu.SetActive(!menu.activeSelf);
        }
        
    }
}
