using UnityEngine;
using System.Collections;

public class TopviewClickMovement : MonoBehaviour {

    Vector3 originalPosition;
    Vector3 clickedPosition;
    bool isMoving = false;
    public float movementSpeed = 1f;
    float startTime;
    float journeyLength;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetButtonDown("Fire2"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                //Debug.Log("clicked");
                startTime = Time.time;
                originalPosition = transform.position;
                clickedPosition = new Vector3(hit.point.x, 0.5f, hit.point.z);
                journeyLength = Vector3.Distance(originalPosition, clickedPosition);
                isMoving = true;
            }
        }
        if (isMoving)
        {

                float distCovered = (Time.time - startTime) * movementSpeed;
                float fracJourney = distCovered / journeyLength;
                transform.position = Vector3.Lerp(transform.position, clickedPosition, fracJourney);
           

        }
        if (transform.position.Equals(clickedPosition))
        {
            isMoving = false;
        }
        //TODO: 길찾기 알고리즘을 구현할 것.

    }
}
