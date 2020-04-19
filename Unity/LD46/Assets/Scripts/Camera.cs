using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Animator anim;
    private float status = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (status == 0)
            {
                anim.SetBool("isMenu", true);
                status = 1;
            }
            else
            {
                anim.SetBool("isMenu", false);
                status = 0;
            }
        }
    }
}
