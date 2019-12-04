using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GShare;

public class PowerupHandler : MonoBehaviour
{
    #region values
    public float time;
    private float DefTScale;
    Type currentPow;
    #endregion

    #region private variables
    private SphereCollider sc;
    private Rigidbody rb;
   // private Ball bll;
    #endregion


    #region default methods
    // Start is called before the first frame update
    void Start() {
        DefTScale = Time.timeScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0f) time -= Time.deltaTime;
    }
    #endregion
    /*
   #region methods

   void flot(float t) { currentPow = Type.flot; }
   void slow(float t) { currentPow = Type.slow; }
   void speed(float t) { currentPow = Type.speed; }
   void bounce(float t) { currentPow = Type.bounce; }
   void jump(float t) { currentPow = Type.jump; }
   void heavy(float t) { currentPow = Type.heavy; }
   void big(float t) { currentPow = Type.big; }
   void small(float t) { currentPow = Type.small; }
 
#endregion
     */
}
