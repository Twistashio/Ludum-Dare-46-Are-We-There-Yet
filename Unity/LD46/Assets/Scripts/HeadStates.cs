using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadStates : MonoBehaviour
{
    public GameObject headState1;
    public GameObject headState2;
    public GameObject headState3;

    

    private void Start()
    {
        headState2.SetActive(false);
        headState3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (BoringMeter.slideValue <= 0.42 && BoringMeter.slideValue > 0f)
        {
          
                headState2.SetActive(false);
                headState3.SetActive(false);
                headState1.SetActive(true);
           
        }

        if (BoringMeter.slideValue < 2.5 && BoringMeter.slideValue > 0.42f)
        {
            headState2.SetActive(true);
            headState3.SetActive(false);
            headState1.SetActive(false);
        }

        if (BoringMeter.slideValue >= 2.5)
        {
            headState2.SetActive(false);
            headState3.SetActive(true);
            headState1.SetActive(false);
        }

    }
}
