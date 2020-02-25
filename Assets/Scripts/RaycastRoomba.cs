using UnityEngine;

// usage: put this script on a Cylinder in a simple maze
// intent: make this cylinder ("Roomba") move around and navigate maze
public class RaycastRoomba : MonoBehaviour {
	
    public float roombaDetectionDistance = 4f;
    public float  roombaSpeed = 5f;

	void Update () 
    {
        // STEP 1: define Ray
		// Vector3.forward = world's forward, like "east", never changes    ABSOLUTE
		// transform.forward = this object's forward, changes w/ rotation  RELATIVE
        Ray roombaRay = new Ray(transform.position, transform.forward);

        // STEP 2: define maximum raycast distance
        //         DO IT IN INSPECTOR

        // STEP 3: visualize the raycast
        Debug.DrawRay(roombaRay.origin, roombaRay.direction * roombaDetectionDistance, Color.cyan);

        // STEP 4: shoooot the raycast!!!
        if (Physics.Raycast(roombaRay, roombaDetectionDistance)) // the ray does it all, multipled by length
        {
            // if raycast is true = there's a wall in front of us
			// randomly turn left or right?
            int randomNumber = Random.Range(0, 100);
            if (randomNumber < 50)
            {
                transform.Rotate(new Vector3(0,90,0));  // gotta use vectors!
            }
            if (randomNumber >= 50)
            {
                transform.Rotate(new Vector3(0,-90,0)); // gotta use vectors!
            }
        }
        // otherwise... just move forward
        else
        {
            // rooomba moves universally.  Need ABSOLUTE FORWARD
            transform.Translate(0,0, Time.deltaTime * roombaSpeed);
        }
    }
}