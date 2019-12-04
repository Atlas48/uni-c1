using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunctionCollider : MonoBehaviour
{
   void OnCollisionEnter(Collision c) {
        var g = c.gameObject;
        if (g.layer == 8) g.transform.parent.GetComponent<PatrolEnemy>().ChangeDirection();
    }
}
