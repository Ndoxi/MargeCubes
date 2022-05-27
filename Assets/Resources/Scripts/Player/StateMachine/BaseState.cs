public abstract class BaseState
{
    protected StateMachine context;

    public BaseState(StateMachine context)
    {
        this.context = context;
    }


    public virtual void OnEnterState() { }
    public virtual void OnExitState() { }
    public virtual void OnUndateBehavior() { }
    public virtual void OnLateUpdate() { }
    public abstract void ProcessTransitions();


    public void OnUpdate()
    {
        ProcessTransitions();
        OnUndateBehavior();
    }
}
