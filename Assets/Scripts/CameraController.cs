using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    float speed = 10;

	void Start () {
	}
	
	void Update () {
        if(Input.GetKey(KeyCode.A) == true || Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += -transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D) == true || Input.GetKey(KeyCode.RightArrow)) {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.W) == true || Input.GetKey(KeyCode.UpArrow)) {
            transform.position += ForwardDirection(transform) * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S) == true || Input.GetKey(KeyCode.DownArrow)) {
            transform.position += -ForwardDirection(transform) * Time.deltaTime * speed;
        }
	}

    private Vector3 ForwardDirection(Transform focus) {
        // Get the natural forward transition
        Vector3 naturalForward = focus.forward;
        // Nullify its y-component
        naturalForward.y = 0;
        // Normalize xz-plane and align it with the chosen y-axis
        Vector3 fixedForward = naturalForward.normalized;

        // This gives us a vector whose xz-planar speed is normalized
        // while preserving the fixed Y component
        return fixedForward;
    }
}
