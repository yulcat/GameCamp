using UnityEngine;
using System.Collections;

public class TopviewCharacterMovement : MonoBehaviour {

    public float movement = 0.1f;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * movement , 0f, Input.GetAxis("Vertical") * movement));
	
	}
}
