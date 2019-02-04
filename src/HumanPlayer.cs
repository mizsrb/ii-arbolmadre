using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Type of human that follows the player
public class HumanPlayer : Human {

	// Define the player as its target
	void Start () {
		target = GameController.Player ();

        GameController.instance.OnWin += Die;
    }
}
