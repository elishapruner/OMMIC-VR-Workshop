using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointShootCamera : MonoBehaviour {

	float speed = 10.0f;

	void Update() {

    if (Input.GetAxis("Mouse X") > 0 || Input.GetAxis("Mouse X") < 0) {
			float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed;
			float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed;

			transform.position += new Vector3(mouseX, 0.0f, mouseY);
    }
	}

}
