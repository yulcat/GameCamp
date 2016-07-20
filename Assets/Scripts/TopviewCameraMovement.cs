using UnityEngine;
using System.Collections;

public class TopviewCameraMovement : MonoBehaviour {
    //탑뷰 시점에서 카메라를 캐릭터와 마우스 위치에 따라 적절하게 이동하는 스크립트입니다.
    //
    public Transform character;
    public bool zoom = false;
    public float minHeight = 10;
    public float maxHeight = 20;
    public float ratio = 0.1f;//캐릭터와 마우스 사이, 카메라가 위치할 지점의 비율

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (character)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                transform.position = new Vector3(((1-ratio) * character.position.x + ratio * hit.point.x), 10, ((1-ratio) * character.position.z + ratio* hit.point.z));

            }
        }
	}
}
