using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    public float damage;
    public float time = 5f;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        if (time == 0f) time = 5f;
    }

    public void ApplyVel(Vector2 dir,float speed) {
        rb.velocity = dir * speed;
        Destroy(gameObject, time);
    }
    private void OnCollisionEnter(Collision collision) {
        Destroy(gameObject);
    }
}
