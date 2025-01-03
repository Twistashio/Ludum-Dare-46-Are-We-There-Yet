﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExit : MonoBehaviour
{
    public float delay = 8f;
    
    public delegate void ExitAction();
    public static event ExitAction OnChunkExited;

    private bool exited = false;

    private void OnTriggerExit(Collider other)
    {
                OnChunkExited();
                StartCoroutine(WaitAndDeactivate());
            }


       
    

    IEnumerator WaitAndDeactivate()
    {
        yield return new WaitForSeconds(delay);

        transform.root.gameObject.SetActive(false);

    }



}
