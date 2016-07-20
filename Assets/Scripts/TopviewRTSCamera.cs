using UnityEngine;
using System.Collections;

public class TopviewRTSCamera : MonoBehaviour {

    public Transform character;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(new Vector3(character.position.x, 10f, character.position.z));
        }
        
	
	}
}
