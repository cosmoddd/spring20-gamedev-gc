using UnityEngine;

// check to see if raycast is grounded
public class RaycastGrounded : MonoBehaviour
{
    public float maxDistance = 1;

    // Update is called once per frame
    void Update()
    {

        // 1 declare the ray in update, right at the point of origin and point it DOWN
        Ray myRay = new Ray(transform.position, Vector3.down);

        // 2 set the raycast's max distance
        

        // 3 draw a debug line that shows the ray being drawn, with info being fed from myRay
        Debug.DrawRay(myRay.origin, myRay.direction * maxDistance, Color.yellow);

        // 4 actually shoot the raycast.  shoots it every frame.  if it hits... do something cool
        if (Physics.Raycast(myRay, maxDistance))
        {
            // if true: it hit someting.  fire off a message:
            Debug.Log("YA HIT SOMETHING!");
        }
        else
        {
            // if false... rotate the cube!!
            transform.Rotate(0,5f,0);
        }
    }
}
