using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// purpOse: move the agent based on where you click
// RTS STYLE
public class NavMeshMoveFromClick : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent thisAgent;


    void Start()
    {
        thisAgent = GetComponent<NavMeshAgent>();        
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // cast the ray in one simple line, based on mouse position on the screen
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit myHit))
            {
                target.transform.position = myHit.point;
            }

            thisAgent.SetDestination(target.transform.position);
        }
    }
}
