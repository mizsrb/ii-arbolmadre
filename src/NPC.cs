using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Basic class for the characters that are not controlled by the player
public abstract class NPC : MovingBeing {
	const float MAX_DISTANCE_TO_TARGET = 100f;  // Maximum distance in which the target can be perceived
	const float MIN_DISTANCE_TO_TARGET = 6f;    // Closer to this distance the object only looks at the target

    // Follow the specified GameObject
	protected void Follow(GameObject o) {
		if(Vector3.Distance(transform.position, o.transform.position) < MAX_DISTANCE_TO_TARGET) {
			transform.LookAt (o.transform);
			if (Vector3.Distance (transform.position, o.transform.position) > MIN_DISTANCE_TO_TARGET)
				MoveForward ();
		}
	}
}
