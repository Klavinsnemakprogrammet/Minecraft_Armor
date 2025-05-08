using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{

    public void ToUIScene()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);

    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene("Menu",LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
