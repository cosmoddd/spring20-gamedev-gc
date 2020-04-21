
using UnityEngine;
using UnityEngine.AI;

// purpose: move the agent based on where you click
// REAL TIME STRATEGY ACTION
public class NavMeshWithClick : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent thisAgent;

    void Start()
    {
        thisAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // shorthand for getting a hit from the camera on the frame that you clicked the mouse

            //  cast the ray...     ... from the screen point based on mouse pos...  getting the hit...  
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit myHit))
            {
                target.transform.localPosition = myHit.point;
            }

            thisAgent.SetDestination(target.transform.position);
        }
    }
}
