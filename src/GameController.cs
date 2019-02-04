using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void Win();
public delegate void Lose();

// Class in charge of coordinating interactions between objects
public class GameController : MonoBehaviour {
	public static GameController instance;  // Only instance of the GameController
	public static GameObject player;    // Reference to the player
	public static GameObject artemisa;  // Reference to Artemisa

    public event Win OnWin; // Methods that should be called when the game is won subscribe to this event 
    public event Lose OnLose; // Methods that should be called when the game is lost subscribe to this event

    // Make sure that only one instance is created
    void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(this);
		}
		else if (instance != this)
			Destroy(gameObject);
	}

    // Make objects in the game able to access the player
	public static GameObject Player() {
		return player;
	}

    // Make objects in the game able to access Artemisa
    public static GameObject Artemisa() {
		return artemisa;
	}

    // Move the player to the location of the received Transform
    public static void MovePlayer(Transform tf) {
        player.transform.position = tf.position + new Vector3(1.0f, 1.0f, 1.0f);
    }

    // Method that is called when the player wins
    public void Win() {
        Debug.Log("Win");
        OnWin();
    }

    // Method that is called when the player loses
    public void Lose()
    {
        Debug.Log("Lose");
        OnLose();
    }
}
