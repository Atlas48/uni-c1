using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
#if UNITY_EDITOR
    [Tooltip("The panel for the menu")]
#endif
    public GameObject menpan;
    private void Start() {
        if (Time.timeScale == 0f) Time.timeScale = 1f;
    }
    public enum QuitType {
        toMenu,
        toDesktop,
        toGame
    }
    public void ExitTo(QuitType n) {
        switch (n) {
            case QuitType.toDesktop: Application.Quit(); break;
            case QuitType.toMenu: SceneManager.LoadScene("menu"); break;
            case QuitType.toGame: gameObject.SetActive(false); break;
            default: break;
        }
    }

    public void ExitTo(int n) {
        switch (n) {
            case (int)QuitType.toDesktop: Application.Quit(); break;
            case (int)QuitType.toMenu: SceneManager.LoadScene("menu"); break;
            case (int)QuitType.toGame: menpan.SetActive(false); break;
            default: break;
        }
    }
    public void QuitToDesktop() { ExitTo(QuitType.toDesktop); }
    public void QuitToGame() { ExitTo(QuitType.toGame); }
    public void QuitToMenu() { ExitTo(QuitType.toDesktop); }
    public void NewGame() { SceneManager.LoadScene("rollerball-hub"); }
    public void NewGame2D() { SceneManager.LoadScene("2D01"); }
}
