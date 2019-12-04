using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GShare;

public class Door : MonoBehaviour {
    public string kc;

    public void OnCollisionEnter2D(Collision2D c) {
        print("Collision!");
        //if (c.gameObject.tag == "Player" && Global2D.HasKeyType[dc]) Destroy(gameObject);
        //if (c.gameObject.tag == "Player" && MatchKey(kc)) Destroy(gameObject);
        if (c.gameObject.tag == "Player") {
            switch (kc) {
                case "red":   if  (Global2D.RedKey) Destroy(gameObject); break;
                case "blue":  if (Global2D.BlueKey) Destroy(gameObject); break;
                case "green": if(Global2D.GreenKey) Destroy(gameObject); break;
                case "white": if(Global2D.WhiteKey) Destroy(gameObject); break;
                default: break;
            }
        }
    }
}