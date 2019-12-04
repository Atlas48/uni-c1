using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {
    Vector2 direction, lastDirection;
    Rigidbody2D trb;
    SpriteRenderer tsr;
    public List<Sprite> slist;
    public float SpeedMultiplier = 1f;
    public List<Sprite> SpriteState;
    public GameObject bullet;
    public bool canShoot;
    // Start is called before the first frame update
    void Start() {
        if (lastDirection == null) lastDirection = new Vector2(1f, 0f);
        trb = GetComponent<Rigidbody2D>();
        tsr = GetComponent<SpriteRenderer>();
        slist.Add(tsr.sprite);
        foreach (var i in SpriteState) slist.Add(i);
    }

    // Update is called once per frame
    void Update() {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (direction != Vector2.zero) lastDirection = direction;
        if(Input.GetButtonDown("Fire1") && canShoot) {
            Vector3 offset = transform.position + new Vector3(lastDirection.x, lastDirection.y, 0f);
            var schut = GameObject.Instantiate(bullet, offset, Quaternion.identity);
            schut.GetComponent<Bullet>().ApplyVel(lastDirection, 10f); 
        }
    }

    private void FixedUpdate() {
        trb.velocity = direction * SpeedMultiplier;
    }
}
