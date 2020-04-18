using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BorringManager : MonoBehaviour
{
    public float removeValue = 0.3f;


    public void Update()
    {
        //incomplete code
    }


    public void Keys()
    {
        
        if (BoringMeter.slideValue > removeValue)
        {
            BoringMeter.slideValue = BoringMeter.slideValue - removeValue;
        }
    }
}
