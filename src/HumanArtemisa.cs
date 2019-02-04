using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Type of human that follows Artemisa
public class HumanArtemisa : Human {

    // Define Artemisa as its target
    void Start () {
		target = GameController.Artemisa ();
        GameController.instance.OnWin += Die;
    }

}
