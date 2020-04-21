using UnityEngine;
using UnityEngine.AI;

// purpose: simply move to a new location on start.

public class NavMeshMove : MonoBehaviour
{
    // 1) declare the goal and the agent ahead of time.
    public GameObject goal;
    public NavMeshAgent agent;

    void Start()
    {
        // get the agent on Start
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.transform.position;  // should just go to the position.  no fuss.  no update

    }

}
