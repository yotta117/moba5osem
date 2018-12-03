using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingFabrica : AIState {

    [SerializeField]
    [Range(1.0f, 10.0f)]
    private float _speed = 3.0f;
    [SerializeField]
    [Range(0.1f, 10.0f)]
    private float _slerpSpeed = 3.0f;
    [SerializeField]
    [Range(0.0f, 10.0f)]
    private float _stoppingDistance = 1.0f;
    [SerializeField]
    [Range(5.0f, 25.0f)]
    private float _exitDistance = 5.0f;
    [SerializeField]
    [Range(0.0f, 2.0f)]
    public float _attackDistance;

    public override AIStateType GetStateType()
    {
        return AIStateType.Chasing;
    }

    public override void OnEnterState()
    {
        _machine.turnOnSpot = 0.0f;
        _machine.speed = _speed;
        _machine.attackDistance = _attackDistance;

        _machine.SetNavAgentControl(true, false);
        _machine.SetAnimatorRootMotionControl(true, false);
    }

    public override void OnExitState()
    {
        
    }

    public override AIStateType OnUpdate()
    {
        Quaternion newRot = Quaternion.LookRotation(_machine.navAgent.desiredVelocity);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRot, Time.deltaTime * _slerpSpeed);

        _machine.navAgent.SetDestination(_machine.playerTarget.transform.position);
        

        if (Vector3.Distance(_machine.playerTarget.transform.position, transform.position) < _attackDistance)
        {
            return AIStateType.Attack;
        }
        //
        if (Vector3.Distance(_machine.playerTarget.transform.position, transform.position) > _exitDistance)
        {
            return AIStateType.Idle;
        }

        return AIStateType.Chasing;
    }
}
