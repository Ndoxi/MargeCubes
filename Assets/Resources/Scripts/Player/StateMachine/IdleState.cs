public class IdleState : BaseState
{
    public IdleState(StateMachine context) : base(context) { }


    public override void ProcessTransitions() 
    {
        if (context.ScriptManager.InputHandler.IsAimingStarted)
        {
            AimState aimState = context.AimState;
            context.SetNewState(aimState);
        }
    }
}