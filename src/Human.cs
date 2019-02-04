using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Base class for different types if humans (enemies)
public abstract class Human : NPC {
	protected GameObject target;    // Who is followed by the human (the player or Artemisa)
	
	// Follow its target
	void Update () {
		Follow (target);
	}

    // Destroy the Human if it dies
    protected override void Die() {
        if (gameObject != null)
            Destroy(gameObject);
    }
}
