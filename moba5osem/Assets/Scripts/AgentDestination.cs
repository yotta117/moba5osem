using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentDestination : MonoBehaviour {

    RaycastHit hitInfo = new RaycastHit();
    NavMeshAgent agent;
    EnemyMinion motion;

    private GameObject playerPos;

    //Patrol
    public Transform[] points;
    private int destPoint = 0;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        playerPos = GameObject.FindGameObjectWithTag("Player");
        motion = GetComponent<EnemyMinion>();
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    if(Physics.Raycast(ray.origin, ray.direction, out hitInfo))
        //    {
        //        //agent.destination = hitInfo.point;
        //        Debug.Log(hitInfo);
        //    }
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    agent.SetDestination(playerPos.transform.position);
        //}
        if(!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GoToNext();
        }
	}

    private void GoToNext()
    {
        if (points.Length == 0)
        {
            return;
        }

        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;

        motion.ShouldMove();
    }
}
