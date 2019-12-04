using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMono : MonoBehaviour
{
#region values
    public Vector3 lastCP;
    public Transform startPoint;
    public GameObject player;
    public static bool[] HasKey = new bool[8];
#endregion
    // Start is called before the first frame update
    void Start()
    {
        for(var i=0; i<HasKey.Length; i++) HasKey[i]=false;
        if (player == null) player = GameObject.FindWithTag("Player");
        lastCP = startPoint.position;
        player.transform.position = lastCP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
