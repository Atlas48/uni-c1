using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject SpawnObject;
    public bool spawnAtStart;
    float SpawnTimer;
    public float SpawnRate;

    // Start is called before the first frame update
    void Start() {
        if (SpawnObject == null) Debug.LogError("Spawn object");
        if (spawnAtStart) Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer += Time.deltaTime;
        if(SpawnRate>=SpawnTimer) {
            Spawn();
            SpawnTimer = 0f;
        }

    }
    void Spawn() {
        Instantiate(SpawnObject, transform.position, Quaternion.identity);
    }
}
