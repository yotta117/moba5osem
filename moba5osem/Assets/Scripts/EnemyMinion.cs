using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]
public class EnemyMinion : MonoBehaviour {

    private float speed;
    private Vector2 smoothDeltaP = Vector2.zero;
    private Vector2 velocity = Vector2.zero;

    NavMeshAgent agent;
    Animator animator;
    public bool shouldMove;

    //private GameObject playerPos;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        //shouldMove = false;
        //playerPos = GameObject.FindGameObjectWithTag("Player");
        //agent.updatePosition = false;
	}
	
	// Update is called once per frame
	void Update () {
        //agent.SetDestination(playerPos.transform.position);
        Vector3 worldDeltaPosition = agent.nextPosition - transform.position;

        float dx = Vector3.Dot(transform.right, worldDeltaPosition);
        float dy = Vector3.Dot(transform.forward, worldDeltaPosition);
        Vector2 deltaPosition = new Vector2(dx, dy);

        float smooth = Mathf.Min(1.0f, Time.deltaTime / 0.5f);
        smoothDeltaP = Vector2.Lerp(smoothDeltaP, deltaPosition, smooth);

        if(Time.deltaTime> 1e-5f)
        {
            velocity = smoothDeltaP / Time.deltaTime;
        }



        //shouldMove; //= velocity.magnitude > 0.5f && agent.remainingDistance > agent.radius;

        animator.SetBool("Move", shouldMove);
        animator.SetFloat("Horizontal", velocity.x);
        animator.SetFloat("Vertical", velocity.y);

        GetComponent<LookAt>().lookAtTargetPosition = agent.steeringTarget + transform.forward;

        Debug.Log("X" + velocity.x);
        Debug.Log("Y" + velocity.y);
    }

    public void ShouldMove()
    {
        shouldMove = velocity.magnitude > 0.5f && agent.remainingDistance > agent.radius;
    }

    void OnAnimatorMove()
    {
        Vector3 position = animator.rootPosition;
        position.y = agent.nextPosition.y;
        transform.position = position;
    }

    //http://unityclassroom.com/tutorial/usar-navmesh-rootmotion-unity/
}
