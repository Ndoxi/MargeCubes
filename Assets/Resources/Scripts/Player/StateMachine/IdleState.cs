public class IdleState : BaseState
{
    public IdleState(StateMachine context) : base(context) { }


    public override void ProcessTransitions() { }

    public override void OnEnterState()
    {
        SpawnerScript.NewCubeSpawnedEvent += StartAiming;
    }

    public override void OnExitState()
    {
        SpawnerScript.NewCubeSpawnedEvent -= StartAiming;
    }


    private void StartAiming()
    {
        AimState newState = context.AimState;
        context.SetNewState(newState);
    }
}
