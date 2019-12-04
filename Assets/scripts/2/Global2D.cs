using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global2D : MonoBehaviour {
#region variables
    public Vector3 lastCP;
    public Transform startPoint;
    public GameObject player;
    public GameObject pauseMenu;
    public bool paused;
    public static int shootscore;
    public static int score;
    public static int lives;
    #region keys
    public static bool RedKey   = false;
    public static bool BlueKey  = false;
    public static bool GreenKey = false;
    public static bool WhiteKey = false;
    #endregion

#endregion
#region methods
    // Start is called before the first frame update
    void Start() {
        if (player == null) player = GameObject.FindWithTag("Player");
        lastCP = startPoint.position;
        player.transform.position = lastCP;
        pauseMenu.SetActive(false);
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            paused = !paused;
            PauseMenu(paused);
        }
    }
#if CSHARP_7_3_OR_NEWER
    private void OnGUI() =>  GUI.Label(new Rect(10,10,150,100), $"Pings: {score.ToString()}/{shootscore.ToString()}");

#else
        private void OnGUI() {
        GUI.Label(new Rect(10,10,150,100), "Pings: "+score.ToString())+"/"+shootscore.ToString());
    }
#endif
    public void PauseMenu(bool b) {
        pauseMenu.SetActive(b);
        Time.timeScale = b ? 1f : 0f;
    }
#endregion
}