using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public static float score;

        // Update is called once per frame
    void Update()
    {
        if (GameManager.gameHasEnded == false)
        {
            score = (((player.position.x * -1f) - 971.7f) / 20f);
            scoreText.text = score.ToString("0");
        }
    }
}
