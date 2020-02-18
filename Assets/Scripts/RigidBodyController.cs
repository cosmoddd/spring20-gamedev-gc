using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyController : MonoBehaviour
{
    public Rigidbody thisRigidBody;
    public float forwardBackward;
    public float rightLeft;

    void Start()
    {
        // get the rigidbody at the start
        thisRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // input handling

        // use Input to determine this... usually defaults

        // vertical = w/s  up and down  Up = +1.  Down = -1
        forwardBackward = Input.GetAxis("Vertical");

        // horizontal by default = a/d.  Left / Right ... Left = -1f, Right is 1f;
        rightLeft = Input.GetAxis("Horizontal");

        // put values into input.Vector, for FixedUpdate()

    }

    // fixed update runs every physics frame.
    // to change physics framerate, go to Edit -> Project Settings -> Time
    void FixedUpdate()
    {
        // don't go faster than 4f
        if (thisRigidBody.velocity.magnitude < 4f)
        {
            thisRigidBody.AddForce(transform.forward * forwardBackward, ForceMode.Impulse);
        }

        thisRigidBody.AddTorque(new Vector3(0, rightLeft, 0), ForceMode.Impulse);
    }
}
