using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public float health = 2f;
    [Tooltip("Does this entity spawn an object?")]
    public bool spawnsObject;
    [Tooltip("The object that spawns on entity's death")]
    public GameObject SpawnObject;

    // Update is called once per frame
    void Update() {
        if(health <= 0f) {
            if (spawnsObject && SpawnObject!=null) Instantiate(SpawnObject, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D c) {
        if (c.gameObject.tag == "bullet") health -= c.gameObject.GetComponent<Bullet>().damage;
    }
}
