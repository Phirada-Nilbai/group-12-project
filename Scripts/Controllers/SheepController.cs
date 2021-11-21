using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SheepController : MonoBehaviour {

    private NavMeshAgent _agent;
    public GameObject player;
    public float distancetoRun = 4f;
    private Animator anim;
	void Start () {
        _agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(transform.position,player.transform.position);
        if (distance<distancetoRun)
        {
            Vector3 dirToPlayer = transform.position - player.transform.position;
            Vector3 newPos = transform.position + dirToPlayer;
            _agent.SetDestination(newPos);
            anim.SetBool("walk",true);
        }
        else
        {
            anim.SetBool("walk", false);
        }
	}
}
