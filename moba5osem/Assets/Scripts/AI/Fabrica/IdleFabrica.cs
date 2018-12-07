using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleFabrica : AIState {

    [SerializeField, Range(0.1f, 10.0f)] private float _idleTime = 3.0f;
    [SerializeField, Range(5.0f, 25.0f)] private float enemyDetectDistance = 5.0f;
    [SerializeField] private float _maxAngle = 45.0f;
    [SerializeField] private float _minAngle = 20.0f;

    private float _timer = 0.0f;

    public override AIStateType GetStateType()
    {
        return AIStateType.Idle;
    }

    public override void OnEnterState()
    {
      
        _machine.navAgent.path = new UnityEngine.AI.NavMeshPath(); //clear the path
        _machine.speed = 0.0f;
        _timer = _idleTime;

        _machine.SetNavAgentControl(true, false);
        _machine.SetAnimatorRootMotionControl(true, true);
    }

    public override void OnExitState()
    {
        
    }

    public override AIStateType OnUpdate()
    {
        //_timer -= Time.deltaTime;
        //if (_timer < 0.0f)
        //{
        //    return AIStateType.Idle;
        //}

        if (_machine.navAgent.pathPending)
        {
            return AIStateType.Idle;
        }

        float angle = FSM.FindSignedAngle(transform.forward, (_machine.navAgent.steeringTarget - transform.position));

        if (_machine.navAgent.hasPath && Mathf.Abs(angle) >= _maxAngle && !_machine.IsAnimationPlaying("TurnOnSpotBlendTree"))
        {
            _machine.turnOnSpot = angle;
        }

        if (Vector3.Distance(_machine.playerTarget.transform.position, transform.position) < enemyDetectDistance)
        {
            
            return AIStateType.Chasing;
        }

        if (_machine.health < 0.0f)
        {
            return AIStateType.Dead;
        }

        //Debug.Log(Vector3.Distance(_machine.playerTarget.transform.position,transform.position) + "Distancia jugador:" + enemyDetectDistance);

            //if (Mathf.Abs(angle) < _minAngle && Vector3.Distance(_machine.playerTarget.transform.position,transform.position) < _enemyDetectDistance)
            //{
            //    //if (Vector3.Distance(_machine.playerTarget.transform.position, transform.position) < _enemyDetectDistance)
            //    //{
            //        Debug.Log("Persiguiendo: " + Vector3.Distance(_machine.playerTarget.transform.position, transform.position));
            //        return AIStateType.Chasing;
            //    //}

            //}
            //else
            //{
            //    return AIStateType.Idle;
            //}


            return AIStateType.Idle;
    }
}
