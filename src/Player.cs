using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script attached to the GameObject of the player
public class Player : MovingBeing {

    // Tell the GameController that he is the player
	void Awake() {
		GameController.player = gameObject;
	}

    // Define specific health points
    void Start() {
        maxhp = 6;
        hp = maxhp;
    }

    // Receive damage when humans can attack him
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Human") {
            ReceiveDmg(1);
        }
    }

    // If the player dies the game is lost
    protected override void Die() {
        GameController.instance.Lose();
    }
}
