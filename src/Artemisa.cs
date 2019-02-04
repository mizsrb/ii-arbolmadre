using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script attached to the GameObject representing Artemisa
public class Artemisa : NPC {

    // Tell the GameController that she is the Artemisa
    void Awake() {
		GameController.artemisa = gameObject;
	}

	// Define specific health points
	void Start () {
		maxhp = 8;
		hp = maxhp;
	}
	
	// Follow the player
	void Update () {
		Follow (GameController.Player());
	}


    // Receive damage when humans can attack her
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Human")
        {
            ReceiveDmg(1);
        }
    }

    // If Artemisa dies the game is lost
    protected override void Die() {
        GameController.instance.Lose();
    }
}
