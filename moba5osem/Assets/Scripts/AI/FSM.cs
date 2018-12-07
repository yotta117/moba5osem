using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum AIStateType
{
    Idle,
    Patrol,
    Chasing,
    Attack,
    Dying,
    Dead
}


[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(NavMeshAgent))]
public class FSM : MonoBehaviour {

    [SerializeField]
    private Dictionary<AIStateType, AIState> _states = new Dictionary<AIStateType, AIState>();
    [SerializeField]
    private AIStateType _currentStateType = AIStateType.Idle;

    private AIState _currentState = null;
    private Animator _animator = null;
    private NavMeshAgent _navAgent = null;
    private float _speed = 0.0f;
    private float _attackDistance = 0.0f;
    private float _turnOnSpot = 0.0f;
    private bool _useRootRotation = false;
    private bool _useRootPosition = false;
    public bool isTurning = false;
    public bool isAttack = false;
    //Recibir daño
    public bool hitDamage = false;
    private Vista _vistaHit = null;
    private float _timerDanno = 1.0f;
    public bool isDead = false;
    [HideInInspector]
    public float health;

    public Vista VistaHit
    {
        get
        {
            return _vistaHit;
        }
    }

    [SerializeField]
    private AIWaypointNet _waypointNetwork = null;

    public AIWaypointNet waypointNetwork
    {
        get
        {
            return _waypointNetwork;
        }
    }

    
    private EnemyStats _stat = null;

    public EnemyStats enemyStat
    {
        get
        {
            return _stat;
        }
    }

    private GameObject _playerTarget = null;

    public GameObject playerTarget
    {
        get
        {
            return _playerTarget;
        }
        set
        {
            _playerTarget = value;
        }
    }

    public float speed
    {
        get
        {
            return _speed;
        }
        set
        {
            _speed = value;
        }
    }
    
    public float attackDistance
    {
        get
        {
            return _attackDistance;
        }
        set
        {
            _attackDistance = value;
        }
    }

    public float turnOnSpot
    {
        get
        {
            return _turnOnSpot;
        }
        set
        {
            _turnOnSpot = value;
        }
    }

    public NavMeshAgent navAgent
    {
        get
        {
            return _navAgent;
        }
    }

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _navAgent = GetComponent<NavMeshAgent>();
        _stat = GetComponent<EnemyStats>();
        _vistaHit = GetComponent<Vista>();
        playerTarget = GameObject.FindGameObjectWithTag("Player");
    }

    // Use this for initialization
    void Start () {
        AIState[] states = GetComponents<AIState>();

        for(int n = 0; n < states.Length; n++)
        {
            if(states[n]!=null && !_states.ContainsKey(states[n].GetStateType()))
            {
                _states[states[n].GetStateType()] = states[n];
                states[n].SetStateMachine(this);
            }
        }

        if (_states.ContainsKey(_currentStateType))
        {
            _currentState = _states[_currentStateType];
            _currentState.OnEnterState();
        }
        else
        {
            _currentState = null;
            Debug.LogError("Falta estado inicial");
            Debug.Break();
        }

	}

    // Update is called once per frame
    void Update() {
        if (_currentState == null)
            return;

        SetAnimParam();

        AIStateType newStateType = _currentState.OnUpdate();

        if (newStateType != _currentStateType)
        {
            AIState newState = null;

            if (_states.TryGetValue(newStateType, out newState))
            {
                _currentState.OnExitState();
                newState.OnEnterState();
                _currentState = newState;
            }
            else if (_states.TryGetValue(AIStateType.Idle, out newState))
            {
                _currentState.OnExitState();
                newState.OnEnterState();
                _currentState = newState;
            }

            else
            {
                Debug.LogError("Falta el estado");
                Debug.Break();
            }

            _currentStateType = newStateType;
        }

        Debug.Log("Daño" + _stat.health);
        if (hitDamage == true)
        {
            _timerDanno -= Time.deltaTime;
            if (_timerDanno < 0.0f)
            {
                hitDamage = false;
                _animator.SetBool("ReceivingShoot", hitDamage);
            }

        }
        else
        {
            _timerDanno = 1.0f;
        }
        health = _stat.health;

    }

    /// Configure animation root motion
    public void SetAnimatorRootMotionControl(bool updatePosition, bool updateRotaion)
    {
        _useRootPosition = updatePosition;
        _useRootRotation = updateRotaion;
    }

    /// Configure Navigation Agent controll
    public void SetNavAgentControl(bool updatePosition, bool updateRotation)
    {
        _navAgent.updatePosition = updatePosition;
        _navAgent.updateRotation = updateRotation;
    }

    /// Called by Unity before apply rootMotion in the object
    public void OnAnimatorMove()
    {
        if (_useRootPosition)
            _navAgent.velocity = _animator.deltaPosition / Time.deltaTime;
        if (_useRootRotation)
            transform.rotation = _animator.rootRotation;
    }

    /// Set animation parameters
    private void SetAnimParam()
    {
        _animator.SetFloat("TurnOnSpot", _turnOnSpot);
        _animator.SetFloat("Speed", _speed);
        _animator.SetBool("Attack", isAttack);
        _animator.SetBool("IsDead", isDead);
        //_animator.SetBool("ReceivingShoot", hitDamage);
    }

    /// Is the animation already playing?
    public bool IsAnimationPlaying(string animationName, int layer = 0)
    {
        return _animator.GetCurrentAnimatorStateInfo(layer).IsName(animationName);
    }

    /// returns the signed angle
    public static float FindSignedAngle(Vector3 from, Vector3 to)
    {

        //if the two vectors are equal just return 0
        if (from == to)
            return 0.0f;

        //get angle and cross product
        float angle = Vector3.Angle(from, to);
        Vector3 cross = Vector3.Cross(from, to);

        return angle * Mathf.Sign(cross.y);

    }

}
