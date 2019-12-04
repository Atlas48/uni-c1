using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GShare;

public class PowerPedestal : MonoBehaviour
{
    #region public variables
    public GShare.Type powState;
    public float timeFor;
    public SphereCollider sc;
    public Rigidbody rb;
    #endregion

    #region defmethods
    // Start is called before the first frame update
    void Start() {
        if (timeFor == 0f) timeFor = 1f;
        sc = GetComponent<SphereCollider>();
        rb = GetComponent<Rigidbody>();
        //bll = GetComponent<Ball>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnCollisionEnter(Collision c) {
        if(c.gameObject.tag == "Player") c.gameObject.SendMessage(GShare.PowState.Convert(powState), timeFor);
    }
    #endregion

}
