using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {
  public Transform sendTo;
  static bool recentWarp;

  void Start(){ recentWarp=false; }

  private void OnTriggerEnter2D(Collider2D c) {
        var g = c.gameObject;
        var latch = false;
        recentWarp = (!recentWarp && g.tag == "Player");
        if (g.tag == "PatrolEnemy" && g.GetComponent<PatrolEnemy>()!=null) g.GetComponent<PatrolEnemy>().recentWarp = latch = true;
        if (recentWarp || latch) g.transform.position = sendTo.position;
  }
}
