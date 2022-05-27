using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StateMachine : MonoBehaviour
{
    [Header("Script manager")]
    [SerializeField] private PlayerScriptManager _scriptManager;

    private BaseState _currentState;
    private IdleState _idleState;
    private AimState _aimState;

    public PlayerScriptManager ScriptManager { get { return _scriptManager; } }

    public IdleState IdleState { get { return _idleState; } }
    public AimState AimState { get { return _aimState; } }


    private void Start()
    {
        _idleState = new IdleState(this);
        _aimState = new AimState(this);

        _currentState = _idleState;
    }


    private void Update()
    {
        _currentState.OnUpdate();
    }


    private void LateUpdate()
    {
        _currentState.OnLateUpdate();
    }


    public void SetNewState(BaseState newState)
    {
        if (_currentState == newState) { return; }

        _currentState.OnExitState();
        _currentState = newState;
        _currentState.OnEnterState();
    }
}