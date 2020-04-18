using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuHander : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void Scores()
    {
        Debug.Log("Scores");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
