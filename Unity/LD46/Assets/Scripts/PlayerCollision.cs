using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public DrivingControler movement;

    public static int endScore;

    private void Update()
    {
        endScore = (int) Score.score;
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {


        if (collisionInfo.collider.tag == "Hills")
        {
            movement.enabled = false;

            if (endScore > PlayerPrefs.GetInt("Score"))
            {
                PlayerPrefs.SetInt("Score", endScore);
            }

            Debug.Log("We hit an obsticle");
            FindObjectOfType<GameManager>().EndGame();
        }

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;

            if (endScore > PlayerPrefs.GetInt("Score"))
            {
                PlayerPrefs.SetInt("Score", endScore);
            }

            Debug.Log("We hit an obsticle");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
