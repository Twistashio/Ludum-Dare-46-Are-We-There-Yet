using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public DrivingControler movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
       if (collisionInfo.collider.tag == "Hills")
        {
            movement.enabled = false;

            Debug.Log("We hit an obsticle");
        }
    }
}
