using UnityEngine;

public class IdleState : ControllerState
{
    
    public IdleState(StateMachine state) : base(state) { }


    public override void Enter()
    {
        stateMachine.dependencyOptions.animator.CrossFade("Idle", 0.01f);

    }

    public override void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            stateMachine.ChangeState(stateMachine.walkState);
            
        }
    }

    public override void FixedUpdate()
    {


    }

    public override void Exit()
    {


    }


}
