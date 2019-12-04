using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GShare;

public class Keys : MonoBehaviour {

    public string kc;

    private void Start() {
        var bc = GetComponent<BoxCollider2D>();
        if (!bc.isTrigger) bc.isTrigger = true; //make sure it's a trigger
    }

    private void OnTriggerEnter2D(Collider2D c) {
    if (c.gameObject.tag == "Player") {
            Global2D.RedKey = kc == "red";
            Global2D.BlueKey = kc == "blue";
            Global2D.GreenKey = kc == "green";
            Global2D.WhiteKey = kc == "white";
            Destroy(gameObject);
    }
  }
}
