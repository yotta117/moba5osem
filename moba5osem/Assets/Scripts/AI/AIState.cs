using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIState : MonoBehaviour {

    protected FSM _machine = null;

    public abstract AIStateType GetStateType();
    public abstract AIStateType OnUpdate();
    public abstract void OnEnterState();
    public abstract void OnExitState();

    /// Sets the Finite State Machine
    public void SetStateMachine(FSM machine)
    {
        _machine = machine;
    }

}
