using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : MonoBehaviour {
    public int value = 1;

    private void OnTriggerEnter2D(Collider2D collision) {
        Global2D.score += value;
        Destroy(gameObject);
    }
}
