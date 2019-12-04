using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GShare;

public class PatrolEnemyCollider : MonoBehaviour {
    public Direction dir;

    public void OnTriggerEnter2D(Collider2D c) {
        transform.parent.GetComponent<PatrolEnemy>().CollCheck((int)dir, true);
    }
    public void OnTriggerStay2D(Collider2D c) {
        this.OnTriggerEnter2D(c);
    }
    public void OnTriggerExit2D(Collider2D cn) {
        transform.parent.GetComponent<PatrolEnemy>().CollCheck((int)dir, false);
    }
}
