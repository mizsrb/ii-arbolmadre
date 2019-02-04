using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class for characters that move and take damage
public abstract class MovingBeing : MonoBehaviour {
	public float moveSpeed = 3; // Movement of speed
	protected int maxhp; // Health points at the begining of the game
	protected int hp; // Current health points

    // Makes the object move forward
	protected void MoveForward() {
		transform.position += transform.rotation * Vector3.forward * moveSpeed * Time.deltaTime;
	}

    // Makes the object move backwards
    protected void MoveBackwards() {
		transform.position += transform.rotation * -Vector3.forward * moveSpeed * Time.deltaTime;
	}

    // The objects receives the amount of damage specified in the parameter dmg
    // It dies if its health points reach 0
    public void ReceiveDmg(int dmg) {
		hp -= dmg;
		if (hp <= 0) {
			Die ();
		}
	}

    // Concrete MovingBeings should decide what to do when dying
    protected abstract void Die();
}
