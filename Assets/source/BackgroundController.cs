using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

	private float speed;

	void Update () {
		transform.Translate (0, -0.02f, 0);
		if (transform.position.y < -6.5f ) {
			transform.position = new Vector3 (0, 6.5f, 0);
		}
	}

	public void setSpeed(float speed) {
		this.speed = speed;
	}
}
