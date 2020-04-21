using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject gameOver;
    public Text endText;
    public Text bestText;

    public GameObject uiScore;
    public GameObject uiMeter;
    public GameObject uiManager;


    public static bool gameHasEnded = false;


    private void Start()
    {
        gameOver.SetActive(false);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            
            endText.text = PlayerCollision.endScore.ToString() + " " + "Units";
            bestText.text = PlayerPrefs.GetInt("Score") + " " + "Units";

            gameHasEnded = true;
            Time.timeScale = 0.3f;
            Debug.Log("GameOver");
            Invoke("Screen", 1f);
        }
    }

    void Screen()
    {
        uiScore.SetActive(false);
        uiMeter.SetActive(false);
        uiManager.SetActive(false);

        gameOver.SetActive(true);
    }
}
