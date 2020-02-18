using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFPSControllerAlt : MonoBehaviour
{
    public CharacterController thisCharacterController;

    public float forwardBackward;
    public float rightLeft;

    public float moveSpeed = 5f;

    public Vector3 inputVector;

    // Start is called before the first frame update
    void Start()
    {
        thisCharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
		float mouseX = Input.GetAxis("Mouse X"); // horizontal mouse movement
		float mouseY = Input.GetAxis("Mouse Y"); // vertical mouse movement
		
        transform.Rotate( 0f, mouseX, 0f); // yaw
		Camera.main.transform.Rotate( -mouseY, 0f, 0f);

        // vertical = w/s  up and down  Up = +1.  Down = -1
        forwardBackward = Input.GetAxis("Vertical");
        // horizontal by default = a/d.  Left / Right ... Left = -1f, Right is 1f;
        rightLeft = Input.GetAxis("Horizontal");

        // so, let's create a transform vector
		inputVector = transform.forward * forwardBackward; // forward
		inputVector += transform.right * rightLeft; // strafe

        thisCharacterController.Move((inputVector * moveSpeed) + (Physics.gravity * 0.69f));

    }

}
