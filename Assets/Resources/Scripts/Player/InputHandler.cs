using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputHandler : MonoBehaviour
{
    private float _touchDeltaX;
    private InputActionPhase _touchPhase;

    public float TuchDeltaX { get { return _touchDeltaX; } }
    public bool IsAimingStarted { get { return _touchPhase == InputActionPhase.Started;  } }
    public bool IsAimingEnded { get { return _touchPhase == InputActionPhase.Canceled; } }

    public void OnTouchMove(InputAction.CallbackContext context)
    {
        _touchDeltaX = context.ReadValue<float>();
    }


    public void OnTouch(InputAction.CallbackContext context)
    {
        _touchPhase = context.phase;
        Debug.Log(context.phase);
    } 
}