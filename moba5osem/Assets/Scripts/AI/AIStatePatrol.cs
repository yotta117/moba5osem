using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStatePatrol : AIState {

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
    [Range(3.0f, 10.0f)]
    private float _enemyDetectDistance = 3.0f;


    /// Called by FSM to knows the state type
    public override AIStateType GetStateType()
    {
        return AIStateType.Patrol;
    }

    /// Called by FSM before enter a state
    public override void OnEnterState()
    {
        //reset values
        _machine.turnOnSpot = 0.0f;
        _machine.speed = _speed;

        //configure rootMotion and navAgent
        _machine.SetNavAgentControl(true, false);
        _machine.SetAnimatorRootMotionControl(true, false);
    }

    /// Called by FSM before leave a state
    public override void OnExitState()
    {

    }

    /// Called by FSM machine every update
    public override AIStateType OnUpdate()
    {
        _machine.isTurning = true;
        //set desire navAgent rotation slowly
        Quaternion newRot = Quaternion.LookRotation(_machine.navAgent.desiredVelocity);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRot, Time.deltaTime * _slerpSpeed);

        //if we reach the destination
        if (Vector3.Distance(_machine.navAgent.destination, transform.position) < _stoppingDistance)
            return AIStateType.Idle;

        //
        if (Vector3.Distance(_machine.playerTarget.transform.position, transform.position) < _enemyDetectDistance)
        {
            Debug.Log("Persiguiendo: "+Vector3.Distance(_machine.playerTarget.transform.position,transform.position));
            return AIStateType.Chasing;
        }

        return AIStateType.Patrol;
    }

}
