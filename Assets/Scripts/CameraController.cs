using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameSettings settings;

    private Rect bounds = new Rect(new Vector2(3.0f, 3.0f), new Vector2(30.0f, 30.0f));
    private float cameraSpeed = 10.0f;

	void Update () {
        if(Input.GetKey(KeyCode.A) == true || Input.GetKey(KeyCode.LeftArrow)) {
            transform.parent.position += -transform.right * Time.deltaTime * cameraSpeed;
        }
        if (Input.GetKey(KeyCode.D) == true || Input.GetKey(KeyCode.RightArrow)) {
            transform.parent.position += transform.right * Time.deltaTime * cameraSpeed;
        }
        if (Input.GetKey(KeyCode.W) == true || Input.GetKey(KeyCode.UpArrow)) {
            transform.parent.position += ForwardDirection(transform) * Time.deltaTime * cameraSpeed;
        }
        if (Input.GetKey(KeyCode.S) == true || Input.GetKey(KeyCode.DownArrow)) {
            transform.parent.position += -ForwardDirection(transform) * Time.deltaTime * cameraSpeed;
        }
        if (Input.GetKeyDown(KeyCode.E) == true) {
            transform.RotateAround(transform.parent.position, transform.parent.up, -90.0f);
        }
        if (Input.GetKeyDown(KeyCode.Q) == true) {
            transform.RotateAround(transform.parent.position, transform.parent.up, 90.0f);
        }
        transform.parent.position = new Vector3(Mathf.Clamp(transform.parent.position.x, bounds.xMin, bounds.xMax),
                                                transform.parent.position.y,
                                                Mathf.Clamp(transform.parent.position.z, bounds.yMin, bounds.yMax));
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
