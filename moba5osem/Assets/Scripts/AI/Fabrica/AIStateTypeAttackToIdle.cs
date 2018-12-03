using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStateTypeAttackToIdle : AIState {

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

    private float _attackDistance;

    private AIStateChasing chasing;

    public override AIStateType GetStateType()
    {
        return AIStateType.Attack;
    }

    public override void OnEnterState()
    {
        _machine.turnOnSpot = 0.0f;
        _machine.speed = _speed;
        _attackDistance = _machine.attackDistance;

        chasing = GetComponent<AIStateChasing>();

        _machine.SetNavAgentControl(true, false);
        _machine.SetAnimatorRootMotionControl(true, false);
    }

    public override void OnExitState()
    {

    }

    public override AIStateType OnUpdate()
    {
        _machine.isAttack = true;
        Debug.Log("Ataca");

        if (Vector3.Distance(_machine.playerTarget.transform.position,transform.position)>2.0f)
        {
            _machine.isAttack = false;
            return AIStateType.Idle;
        }
        return AIStateType.Attack;
    }

}
