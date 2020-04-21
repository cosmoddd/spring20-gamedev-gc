using UnityEngine;
using UnityEngine.AI;
// set up a patrol for this guy!
public class NavMeshPatrol : MonoBehaviour
{
    // lay out the waypoints
    public Transform[] waypoints;
    // set the current waypoint at 0
    public int currentWaypoint = 0;
    public NavMeshAgent myAgent;

    // immediately get NavMeshAgent component and go to the next waypoint
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        GoToNextWaypoint();
    }

    void GoToNextWaypoint()
    {
        // if there are no waypoints, get outta here
        if (waypoints.Length == 0)
        {
            return;
        }
        
        // tell NavMeshAgent to go to the waypoint
        myAgent.destination = waypoints[currentWaypoint].position;

        // increment next waypoint
        currentWaypoint++;

        // if waypoint exceeds amount set to zero
        if (currentWaypoint >= waypoints.Length)
        {
            currentWaypoint = 0;
        }
    }

    // so how do we actually tell when to go to the next waypoint?
    void Update()
    {
        if (myAgent.remainingDistance < .3f)
        {
            GoToNextWaypoint();
        }
    }

}
