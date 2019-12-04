using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {
    Global2D gg;
    // Start is called before the first frame update
    void Start() {
        gg = GameObject.Find("Manager").GetComponent<Global2D>();
    }
    public void OnTriggerEnter2D(Collider2D c) {
        gg.lastCP = transform.position;
#if DEBUG || UNITY_EDITOR
        print("New position!");
#endif
       
    }
    public void OnTriggerExit2D(Collider2D c) {
        Physics2D.IgnoreLayerCollision(9, 10, c.gameObject.tag != "Player");
    }
}
