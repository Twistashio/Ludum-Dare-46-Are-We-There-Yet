using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoringMeter : MonoBehaviour
{

    public Slider slider;

    public static float slideValue;
    float timeToWait = 0.5f;
    public float fillQuantity;

    private bool isFailed = false;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0f;
        slideValue = 0f;

        StartCoroutine(FillSlider());
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = slideValue;


        if (slideValue > 2.5 && isFailed == false)
        {
            Fail();
        }
        else
        {
            return;
        }
    }

    public IEnumerator FillSlider()
    {
        if (GameManager.gameHasEnded == false)
        { 
        yield return new WaitForSeconds(timeToWait);
        slideValue += fillQuantity;
        StartCoroutine(FillSlider());
        }
    }

    public void Fail()
    {
       
        FindObjectOfType<GameManager>().EndGame();

    }
}
