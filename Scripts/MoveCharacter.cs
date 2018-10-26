using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	int currTime = 0;

	void Update () {

		currTime += 1;

		if (currTime > 100) {
			float posX = Random.Range(-5.0f, 5.0f);
			float posY = 0.0f;
			float posZ = Random.Range(-5.0f, 5.0f);

			transform.position = new Vector3(posX, posY, posZ);
			currTime = 0;
		}
	}

}
