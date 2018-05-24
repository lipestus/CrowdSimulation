using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour {

	private GameObject[] goalLocations;
	private NavMeshAgent agent;
    private Animator anim;
    private GameObject total;

    // Use this for initialization
    void Start ()
    {
        InitialiseVariables();
    }

    void InitialiseVariables()
    {
        anim = GetComponent<Animator>();
        goalLocations = GameObject.FindGameObjectsWithTag("goal");
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);
        anim.SetFloat("walkingOffset", Random.Range(0, 1));
        anim.SetTrigger("isWalking");
    }
	
	// Update is called once per frame
	void Update () {
		
        if(agent.remainingDistance < 1f)
        {
            agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);
        }
	}
}
