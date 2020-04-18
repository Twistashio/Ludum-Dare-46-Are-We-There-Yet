using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingControler : MonoBehaviour
{

   public Rigidbody rb;


   public float startSpeed;
   public float Acceleration;
   public float tiltSpeed;

    public static bool CanMove;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity=new Vector3(-startSpeed,0,0);

        // Multiplies the lane switching speed so we can imput lower values into the editor
        tiltSpeed = tiltSpeed * 10;

        //If the player can move the car or not
        CanMove = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (CanMove == true)
        {
            rb.AddForce(-Acceleration * Time.deltaTime, 0, 0);

            if (Input.GetKey("d"))
            {
                rb.AddForce(0, 0, tiltSpeed * Time.deltaTime);
            }

            if (Input.GetKey("a"))
            {
                rb.AddForce(0, 0, -tiltSpeed * Time.deltaTime);
            }
            else
            {
                return;
            }
        }
    }
}
