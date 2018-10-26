using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	void Update () {
		Vector3 posOrigin = new Vector3(0, 2, 0);
		transform.LookAt(posOrigin);

		int step = 10;

		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(Vector3.right * step * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(-Vector3.right * step * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate(Vector3.forward * step * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate(-Vector3.forward * step * Time.deltaTime);
		}
	}

}
