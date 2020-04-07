using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSwim : MonoBehaviour
{
    
    public Vector3 destination;
    public float swimSpeed = 3f;

    void Start()
    {
        GetComponent<MeshRenderer>().material.SetColor("_BaseColor", new Color(Random.Range(0,1.0f), 
                                                                                Random.Range(0,1.0f),
                                                                                Random.Range(0,1.0f)));
    }

    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, destination, swimSpeed * Time.deltaTime);

        // Debug.DrawLine(transform.position, destination, Color.yellow);

        // if we reach our destination, pick a new one

        if (Vector3.Distance(transform.position, destination)< .5f)
        {
            destination = new Vector3(Random.Range(-20, 20),Random.Range(-20, 20),Random.Range(-20, 20));
        }

        transform.LookAt(destination);

    }
}
