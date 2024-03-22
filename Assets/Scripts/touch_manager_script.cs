using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class touch_manager_script : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerInput playerInput;

    //private InputAction touchPositionAction:
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
