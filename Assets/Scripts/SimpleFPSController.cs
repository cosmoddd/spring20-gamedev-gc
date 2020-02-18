using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFPSController : MonoBehaviour
{
    public Rigidbody thisRigidBody;

    public float forwardBackward;
    public float rightLeft;

    public float moveSpeed = 5f;

    public Vector3 inputVector;

    // Start is called before the first frame update
    void Start()
    {
        thisRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // MOUSE LOOK!!!
		
		// getting mouse input
		// these are mouse "deltas"... delta = difference
		// these will be 0 when nothing is moving, this ISN'T mouse position
		float mouseX = Input.GetAxis("Mouse X"); // horizontal mouse movement
		float mouseY = Input.GetAxis("Mouse Y"); // vertical mouse movement
		
		// rotations: Pitch Yaw Roll
		// pitch = up/down rotation, X axis
		// yaw = left/right rotation, Y axis
		// roll = rolling motion, Z axis
        transform.Rotate( 0f, mouseX, 0f); // yaw
		Camera.main.transform.Rotate( -mouseY, 0f, 0f);

        // input handling
        // WASD MOVEMENT
		// GetAxis usually returns a float between -1f and 1f
		// when you're not pressing anything, it returns ~0f

        // vertical = w/s  up and down  Up = +1.  Down = -1
        forwardBackward = Input.GetAxis("Vertical");
        // horizontal by default = a/d.  Left / Right ... Left = -1f, Right is 1f;
        rightLeft = Input.GetAxis("Horizontal");

        // so, let's create a transform vector
		inputVector = transform.forward * forwardBackward; // forward
		inputVector += transform.right * rightLeft; // strafe

    }

    void FixedUpdate()
    {
        thisRigidBody.velocity = (inputVector* moveSpeed * Time.fixedDeltaTime * 50) + (Physics.gravity * 0.69f);
    //    thisRigidBody.MovePosition(this.transform.position + inputVector * moveSpeed * Time.fixedDeltaTime);
    }

}
