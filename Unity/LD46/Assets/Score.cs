using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMesh scoreText;

        // Update is called once per frame
    void Update()
    {
        float score = ((player.position.x * -1f) - 971.7f) - 1000;
        scoreText.text = score.ToString();
        
    }
}
