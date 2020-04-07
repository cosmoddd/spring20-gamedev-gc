using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fiiiiish : MonoBehaviour
{

    public Vector3 destination;
    public float swimSpeed = 3f;

    void Start()
    {
        // randomize color
        GetComponent<MeshRenderer>().material.SetColor("_BaseColor", new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f)));        
    }

    // Always swim, boys
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, swimSpeed * Time.deltaTime);

        // draw debug line to destination:

        Debug.DrawLine(transform.position, destination, Color.yellow);

        // if we reach our destination, pick a new one:

        if (Vector3.Distance(transform.position, destination)<2f)
        {
            destination = new Vector3( Random.Range(-10f, 10f), // x pos
                                        Random.Range(-10f, 10f),    // y pos
                                        Random.Range(-10f, 10f));    // z pos

        }

        transform.LookAt(destination);
    }
}
