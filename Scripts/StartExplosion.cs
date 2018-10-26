using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartExplosion : MonoBehaviour {

	public ParticleSystem explosion;
	Camera camera;

	void Start() {
		explosion.Stop();
		camera = GetComponent<Camera>();
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit)) {
				explosion.Play();
      }
		}
		else if (Input.GetMouseButtonUp(0)) {
			explosion.Stop();
		}
	}

}
