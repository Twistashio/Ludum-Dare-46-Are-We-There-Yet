using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{

    public float addMoney = 1;
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Hello");

        Money.moneyAmount = Money.moneyAmount + addMoney;

        Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
