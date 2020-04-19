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
            StartCoroutine(Failed());
        }
        else
        {
            return;
        }
    }

    public IEnumerator FillSlider()
    {

        yield return new WaitForSeconds(timeToWait);
        slideValue += fillQuantity;
        StartCoroutine(FillSlider());

    }

    public IEnumerator Failed()
    {

        Debug.Log("You Failed");
        

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("TesterScene");
        

    }
}
