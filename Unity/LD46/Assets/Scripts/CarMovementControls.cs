using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementControls : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;
    public float speed;


    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()

    {
        Controll();
        rb.AddForce(speed * -6, 0, 0);
    }


    void Controll()
    {


        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(0, 0, 20f);
            Debug.Log("right");
        }
        else
        {
            if (Input.GetAxis("Horizontal") > -1)
            {
                rb.AddForce(0, 0, -20f);
                Debug.Log("left");
            }
            else
            {
                rb.AddForce(speed * -6, 0, 0);

            }
        }
    }
}
