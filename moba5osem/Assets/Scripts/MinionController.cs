using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionController : MonoBehaviour {

    public Transform[] target;
    public float speed;

    private int current;


    void Start() {
        
	}
	
	void Update () {
		if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);

        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == target[current].gameObject)
        {
            current = (current + 1) % target.Length;
            Debug.Log(target[current]);
        }
    }
}
