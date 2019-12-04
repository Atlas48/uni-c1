/* INCREDABLY LONG CODE AHEAD */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GShare;

public class PatrolEnemy : MonoBehaviour {
#region variables
    Global2D gg;
    Rigidbody2D trb;
    [Tooltip("The speed at which the PatrolEnemy travels")]
    public float speed = 3f;
    public bool recentWarp;
    bool[] contact = new bool[4]; //u=0;l=1;d=2;r=3
    Vector2 dir = new Vector2(1f, 0f);
    Direction lastDir;
    Direction reverse;
#if dicts
    Dictionary<Direction,Direction> InvertDict = new Dictionary<Direction,Direction>;
#endif
#endregion
#region methods
    // Start is called before the first frame update
    void Start() {
        trb = GetComponent<Rigidbody2D>();
        if (!trb.freezeRotation) trb.freezeRotation = true;
        gg = GameObject.Find("Manager").GetComponent<Global2D>();
	    ChangeDirection();
        foreach(CircleCollider2D i in GetComponentsInChildren<CircleCollider2D>()) {
            if (!i.isTrigger) i.isTrigger = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate() {
        trb.velocity = dir * speed;
    }

    /**
    * <summary></summary>
    */
    private void OnCollisionEnter2D(Collision2D c) {
        var t = (c.gameObject.tag == "Player");
        if (t) {
            c.gameObject.transform.position = gg.lastCP;
            Global2D.lives--;
        }
        Physics2D.IgnoreLayerCollision(9, 10, t);
    }

    /**
    *
    */
    public void CollCheck(int d, bool c) {
        contact[d] = c;
	    if (d==(int)lastDir) ChangeDirection();
    }

    /**
    * <summary></summary>
    * <seealso cref="CollCheck(int, bool)"/>
    */
    public void SetDirection(Direction d) {
        switch (d) {
            case Direction.up:
                dir = new Vector2(0f, 1f);
                reverse = Direction.down;
                break;
            case Direction.down:
                dir = new Vector2(0f, -1f);
                reverse = Direction.up;
                break;
            case Direction.right:
                dir = new Vector2(1f, 0f);
                reverse = Direction.left;
                break;
            case Direction.left:
                dir = new Vector2(-1f, 0f);
                reverse = Direction.right;
                break;
        }
        lastDir = d;
    }

    /**
    
    */
    public void ChangeDirection() {
        var newDir = false;
        var breaker = 0;
        var routes = 4;
        foreach (bool i in contact) if (i) routes--;
        if (routes == 1) this.SetDirection(Invert(lastDir));
        else {
            while (!newDir) {
                var r = Random.Range(0, 3);
                for (var i = 0; i < 4; i++) {
                    newDir = (r == i && !contact[i] && reverse != (Direction)i);
                    if (newDir) this.SetDirection((Direction)i);
                }

            if (++breaker > 32) {
#if DEBUG || UNIY_EDITOR
                    print("ChangeDirection: Infinite loop detected.");
#endif
                    breaker =0;
                break;
            }
            }
        }
    }
#if !dicts
    /**
    * <summary>Inverts the direction of the first argument</summary
    * <param name="direction">The direction to invert</param>
    * <returns>The inverse direction of the first parameter</returns>
    */
    private Direction Invert (Direction direction) {
        switch (direction) {
            case Direction.up: return Direction.down;
	    case Direction.down: return Direction.up;
	    case Direction.left: return Direction.down;
	    case Direction.right: return Direction.left;
	    default: return Direction.down; //can't happen
        }
#endif
    }
    /* public void SetDirection(int dir) {
        switch (d) {
            case 0:  break;
            case 1: break;
            case 2: break;
            case 3: break;
        }
    } */
#endregion
}
