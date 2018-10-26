# OMMIC-VR-Workshop

<img width="1440" alt="vr_scene" src="https://user-images.githubusercontent.com/7401790/47573845-47120b80-d90c-11e8-9407-3ac8a6100c78.png">


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartExplosion : MonoBehaviour {

	public ParticleSystem explosion;
	SteamVR_TrackedController controller;
	LineRenderer lineRenderer;

	void Awake() {
		explosion.Stop();
	}

	void Start() {
		controller = GetComponent<SteamVR_TrackedController>();

		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.widthMultiplier = 0.1f;
		lineRenderer.positionCount = 2;
	}

	void Update() {
		if (controller.triggerPressed == true) {
			int layerMask = 1 << 8;
			layerMask = ~layerMask;

			RaycastHit hit;
			if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask)) {
				explosion.Play ();
			}

			lineRenderer.positionCount = 2;
			lineRenderer.SetPosition (0, transform.position);
			lineRenderer.SetPosition (1, transform.TransformDirection(Vector3.forward) * 100.0f);
		} else {
			explosion.Stop ();
			lineRenderer.positionCount = 0;
		}
	}

}
