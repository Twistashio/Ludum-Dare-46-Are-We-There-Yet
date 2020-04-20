using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuHander : MonoBehaviour
{

    
    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TesterScene");
        GameManager.gameHasEnded = false;
        Money.moneyAmount = 0f;
    }

    public void Scores()
    {
        Time.timeScale = 1f;
        Debug.Log("Scores");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        Debug.Log("MainMenu");
        GameManager.gameHasEnded = false;
        Money.moneyAmount = 0f;


    }


}
