using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuHander : MonoBehaviour
{
    public GameObject scorePanel;
    public GameObject mainPanel;

    public Text scoreText;

    public void Start()
    {
        scorePanel.SetActive(false);
    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Tutorial");
        GameManager.gameHasEnded = false;
        Money.moneyAmount = 0f;
    }

    public void Scores()
    {
        scorePanel.SetActive(true);
        mainPanel.SetActive(false);
        scoreText.text = PlayerPrefs.GetInt("Score").ToString() + " " + "units";
        Time.timeScale = 1f;
        Debug.Log("Scores");
    }

    public void Quit()
    {
        Application.Quit();
    }


    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        scoreText.text = "Your Scores Have Been Reset";
    }

    public void Back()
    {
        scorePanel.SetActive(false);
        mainPanel.SetActive(true);
    }
}
