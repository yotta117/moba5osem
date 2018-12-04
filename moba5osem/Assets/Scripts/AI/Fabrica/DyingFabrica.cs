using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DyingFabrica : AIState {
    [SerializeField]
    private Animation[] impactAnimations;

    public override AIStateType GetStateType()
    {
        return AIStateType.Dying;
    }

    public override void OnEnterState()
    {
        throw new System.NotImplementedException();
    }

    public override void OnExitState()
    {
        throw new System.NotImplementedException();
    }

    public override AIStateType OnUpdate()
    {
        throw new System.NotImplementedException();
    }
}
