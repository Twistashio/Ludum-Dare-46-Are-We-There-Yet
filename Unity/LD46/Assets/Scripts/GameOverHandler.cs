using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverHandler : MonoBehaviour
{
    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TesterScene");
        GameManager.gameHasEnded = false;
        Money.moneyAmount = 0f;
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
