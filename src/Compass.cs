using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CLass designed to move the compass according to where the playing is looking at
public class Compass : MonoBehaviour {

	public Transform playerTransform;
	Vector3 dir;

	void Start () {
		Input.location.Start ();
	}

	void Update () {
		//dir.z = playerTransform.eulerAngles.y;
		dir.z = Input.compass.trueHeading;
		transform.localEulerAngles = dir;
	}
}
