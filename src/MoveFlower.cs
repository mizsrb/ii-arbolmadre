using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Class in charge of moving the player when he looks at a flower
public class MoveFlower : EventTrigger
{

    // Move the player to the position of the flower he is looking at
    protected void Move() {
        GameController.MovePlayer(transform);

        if (gameObject.name == "LastFlower") {
            GameController.instance.Win();
            Destroy(gameObject);
        }
    }

    // Invoke the method Move() after a short delay when the player looks at a flower
    public override void OnPointerEnter(PointerEventData eventData) {
        Invoke("Move", 0.4f);
    }
}