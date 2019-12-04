using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : MonoBehaviour {
    public Global2D gg;
    private void OnCollisionEnter2D(Collision2D c) {
        if(c.gameObject.tag=="Player") {
            c.gameObject.transform.position = gg.lastCP;
        } else {
            Destroy(c.gameObject); Destroy(gameObject);
        }
    }
}
