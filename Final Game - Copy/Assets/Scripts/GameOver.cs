using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public int sceneToLoad;
    public void EndGame()
    {
        SceneManager.LoadScene(sceneToLoad); // Scene to load
    }
    public void QuitGame() //continue game after dying
    {
        Application.Quit(); //quit scene
        Debug.Log("Continue?"); // start again to game again
    }
}
