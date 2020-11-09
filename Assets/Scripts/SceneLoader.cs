using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadGame( ) {
        SceneManager.LoadScene("tetrisScene");
        Time.timeScale = 1f;
    }

    public void QuitGame( ) {
        Debug.Log("QUIT GAME");
        Application.Quit( );
    }

    public void LoadMainMenu( ) {
        SceneManager.LoadScene("MainMenu");
    }

    public void Pause( ) {
        Time.timeScale = 0f;
        Debug.Log(Time.timeScale);
    }

    public void Resume( ) {
        Time.timeScale = 1f;
    }
}
