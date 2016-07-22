using UnityEngine;
using System.Collections;

public class TopviewRTSCamera : MonoBehaviour {

    public Transform character;

    public float margin = 0.15f;
    public float cameraMovementSpeed = 0.1f;

    
	// Update is called once per frame
	void LateUpdate () {
        //Debug.Log(Input.mousePosition);
        if (Input.GetButton("Jump"))
        {
            transform.position = new Vector3(character.position.x, 10f, character.position.z);
        }
        else
        {
            if (Input.mousePosition.x < margin * Screen.width)
            {
                //move down
                transform.Translate(Vector3.left * cameraMovementSpeed);
                Debug.Log("Down");
            }
            
            if (Input.mousePosition.y < margin * Screen.height)
            {
                //move left
                transform.Translate(Vector3.down * cameraMovementSpeed);

                //transform.Translate(Vector3.left * cameraMovementSpeed);
                Debug.Log("Left");
            }
            if (Input.mousePosition.x > Screen.width * (1 - margin))
            {
                //move up
                transform.Translate(Vector3.right * cameraMovementSpeed);
                Debug.Log("Up");
            }
            if (Input.mousePosition.y > Screen.height * (1 - margin))
            {
                //move right
                transform.Translate(Vector3.up * cameraMovementSpeed);

                //
                Debug.Log("Right");
            }
            

        }


        
	
	}
}
