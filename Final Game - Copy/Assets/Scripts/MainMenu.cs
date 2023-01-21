using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad; // loading scene

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); // loading the main menu scene
    }
}
