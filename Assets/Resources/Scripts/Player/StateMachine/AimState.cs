public class AimState : BaseState
{
    public AimState(StateMachine context) : base(context) { }


    public override void ProcessTransitions() { }


    public override void OnLateUpdate()
    {
        context.ScriptManager.Gameplay.AimCube();

        if (context.ScriptManager.InputHandler.IsAimingEnded)
        {
            context.ScriptManager.Gameplay.FireCube();

            IdleState newState = context.IdleState;
            context.SetNewState(newState);
        }
    }
}
