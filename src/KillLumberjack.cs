using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Class in charge of making humans receive damage and die
public class KillLumberjack : EventTrigger {

    int hp = 2; // Health points of the humans

    // Kill the Human when its health points reach 0 after a small delay to make it smoother
    public void Update() {
        if (hp <= 0)
            Invoke("Die", 0.4f);
    }

    // Destroy the Human
    void Die() {
        Destroy(gameObject);
    }

    // Reduce health points by one when a Human is being looked at by the player
    public override void OnPointerEnter(PointerEventData eventData) {
        hp--;
    }
}
