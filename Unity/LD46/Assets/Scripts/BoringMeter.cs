using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoringMeter : MonoBehaviour
{

    public Slider slider;

    public static float slideValue;


    float timeToWait = 0.5f;
    public float fillQuantity;

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
    }

    public IEnumerator FillSlider()
    {
        if (slider.value < 1)
        {
            yield return new WaitForSeconds(timeToWait);
            slideValue += fillQuantity;
            StartCoroutine(FillSlider());
            Debug.Log("Done");
        }
    }
}
