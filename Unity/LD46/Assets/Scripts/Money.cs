using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{

    public static float moneyAmount;
    public Text moneyValue;

  

    // Update is called once per frame
    void Update()
    {
        moneyValue.text = moneyAmount.ToString();
    }
}
