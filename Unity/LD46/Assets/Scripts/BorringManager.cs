using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BorringManager : MonoBehaviour
{
    public float removeValue = 0.3f;

    //state of the menu closed/open
    public static bool boringMenu;

    public GameObject boringMenuUI;


    public void Start()
    {
        boringMenu = false;
        boringMenuUI.SetActive(false);
    }


    public void Update()
    {
        //Checks if the the E key was pressed and sees if menu is open
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (boringMenu == false)
            {
                BoringMenuOpen();
            }
            else
            {
                BoringMenuClose();
            }   
       }
    }

    //Opens the  menu
    void BoringMenuOpen()
    {
        boringMenu = true;
        boringMenuUI.SetActive(true);

        //SLows down time when menu is open 
        Time.timeScale = 0.7f;

        //turns of player movement
        DrivingControler.CanMove = false;

    }

    //closes the menu
    void BoringMenuClose()
    {
        //slows down time when menu is open
        boringMenu = false;
        boringMenuUI.SetActive(false);
        Time.timeScale = 1f;

        //activates player movement
        DrivingControler.CanMove = true;
    }



    public void Keys()
    {
        
        if (BoringMeter.slideValue > removeValue)
        {
            BoringMeter.slideValue = BoringMeter.slideValue - removeValue;
        }
    }
}
