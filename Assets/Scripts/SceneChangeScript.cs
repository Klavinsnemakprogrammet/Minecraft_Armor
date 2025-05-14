using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{

    public void ToUIScene()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);

    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene("start screen",LoadSceneMode.Single);
    }
    public void ToSettings()
    {
        SceneManager.LoadScene("Settings", LoadSceneMode.Single);

    }

    public void Quit()
    {
        Application.Quit();
    }
}
