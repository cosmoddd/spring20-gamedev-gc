using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// simple script for moving agent to target
public class AgentToTarget : MonoBehaviour
{

    // 1) delcare the goal and the agent ahead of time

    public GameObject target;
    public NavMeshAgent thisAgent;

    void Start()
    {
        // get the agent on start
        thisAgent = GetComponent<NavMeshAgent>();
        thisAgent.destination = target.transform.position;
    }


}
