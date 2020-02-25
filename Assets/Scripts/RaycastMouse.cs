using UnityEngine;

// usage: put this on your Main Camera (+ make sure it's tagged as MainCamera)
// intent: move a sphere around based on mouse cursor raycast
public class RaycastMouse : MonoBehaviour
{
    public GameObject drawingCube;
    public GameObject paintCube;

    public float maxRaycastDistance = 1000f;
	
	// Update is called once per frame
	void Update () {
		// STEP 1: define the Ray
		// ScreenPointToRay is *essential* for doing raycast with mouse.  // GET THE PIXEL COORDINATES!
		Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

		// STEP 2: define the maximum raycast distance

		// STEP 2B: define a RaycastHit variable (we'll get to this later)
        RaycastHit mouseHitObject;

		// STEP 3: visualize the raycast!! (optional)
        Debug.DrawRay(camRay.origin, camRay.direction * maxRaycastDistance, Color.red);

        // STEP 4: hit detection (out ray)
        if (Physics.Raycast(camRay, out mouseHitObject, maxRaycastDistance))
        {
            drawingCube.SetActive(true);
            drawingCube.transform.position = mouseHitObject.point;

            // STEP 5
            // while mouse is down, spawn some paint!
            if (Input.GetMouseButton(0))
            {
            //    Instantiate(paintCube, mouseHit.point, Quaternion.identity).transform.SetParent(mouseHit.transform);
            
                // STEP 7 ... GET THE INSTANTIATED OBJECTS TO ROTATE WITH THE CUBE
                // or

                GameObject paintDaub = Instantiate(paintCube, mouseHitObject.point, Quaternion.identity);
                paintDaub.transform.SetParent(mouseHitObject.transform);
            }

            // STEP 6 
            // while hovering, spin the canvas!
            mouseHitObject.transform.Rotate(new Vector3(0,0, 35*Time.deltaTime), Space.Self);
        }
        else
        {
            drawingCube.SetActive(false);
        }
    }
}
