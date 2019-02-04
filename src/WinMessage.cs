using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Class in charge of showing victory or defeat messages in the canvas
public class WinMessage : MonoBehaviour {
    Text text; // Text displayed in the canvas

	// Subscribe to the events of the GameController - OnWin and OnLose
	void Start () {
        text = GetComponent<Text>();
        GameController.instance.OnWin += ShowVictory;
        GameController.instance.OnLose += ShowDefeat;
    }
	
    // Show the victory message
	void ShowVictory()
    {
        text.text = "¡Victoria!";
    }

    // Show the defeat message
    void ShowDefeat()
    {
        text.text = "Derrota";
    }
}
