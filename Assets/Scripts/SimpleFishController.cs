using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFishController : MonoBehaviour
{
    public float moveSpeed = .05f;
    public float rotationSpeed = .5f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,0,moveSpeed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0,0,-moveSpeed));
        }
    
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -rotationSpeed, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, rotationSpeed, 0));
        }        
    }
}
