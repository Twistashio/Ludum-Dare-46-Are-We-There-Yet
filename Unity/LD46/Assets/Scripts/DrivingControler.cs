using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingControler : MonoBehaviour
{

   public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       rb.AddForce(-50 * Time.deltaTime,0,0);

        if (Input.GetKey("d"))
        {
            rb.AddForce(0,0, 300 * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -300 * Time.deltaTime);
        }
    }
}
