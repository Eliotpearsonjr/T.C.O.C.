using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
// Eliot Pearson 
// CMSC 437 - Spirng 2024

public class touch_manager_script : MonoBehaviour
{
    
    private PlayerInput playerInput;

    private InputAction touchPressAction;
    private void Awake() {
        playerInput = GetComponent<PlayerInput>();
        touchPressAction = playerInput.actions.FindAction("Push");

    }

    private void OnEnable() {
        touchPressAction.performed += TouchPressed;
    }

    private void onDisable() {
        touchPressAction.performed -= TouchPressed;
    }

    public void TouchPressed(InputAction.CallbackContext context) {
        float value = context.ReadValue<float>();
        
    }
}
