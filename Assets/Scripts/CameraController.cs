using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    float speed = 10;

	void Start () {
	}
	
	void Update () {
        if(Input.GetKey(KeyCode.A) == true || Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += new Vector3 (-1 * Time.deltaTime * speed, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D) == true || Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(+1 * Time.deltaTime * speed, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.W) == true || Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0.0f, 0.0f, +1 * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S) == true || Input.GetKey(KeyCode.DownArrow)) {
            transform.position += new Vector3(0.0f, 0.0f, -1 * Time.deltaTime * speed);
        }
	}
}
