using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


// have this navmesh agent follow a series of patrol points
public class NavMeshPatrol2 : MonoBehaviour
{

    public Transform[] waypoints;
    public int currentWayPoint = 0;
    NavMeshAgent myAgent;

    void Start()
    {
        // get the agent
        myAgent = GetComponent<NavMeshAgent>();

        // immediately tell it to go to next waypoint
        GoToNextWaypoint();
    }

    void GoToNextWaypoint()
    {
        // if there are no waypoints, exit the function
        if (waypoints.Length == 0)
        {
            return;
        }

        // set the destination to current waypoint's position
        myAgent.destination = waypoints[currentWayPoint].position;

        // increment counter to next waypoint
        currentWayPoint++;

        if (currentWayPoint >= waypoints.Length)
        {
            currentWayPoint = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (myAgent.remainingDistance < .3f)
        {
            GoToNextWaypoint();
        }
    }
}
