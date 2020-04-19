using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject GameUI;

    // Start is called before the first frame update
    void Start()
    {
        GameUI.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameUI.SetActive(true);
    }
}
