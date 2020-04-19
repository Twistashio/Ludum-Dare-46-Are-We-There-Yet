using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BorringManager : MonoBehaviour
{
    public float removeValue = 0.3f;
    private float value = 3f;

    //state of the menu closed/open
    public static bool boringMenu;
    public static bool keysPressed;

    public GameObject boringMenuUI;
    public Button uiButton;

    public Animation forward;
    public Animation backward;

    public Slider keySlider;


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
        Time.timeScale = 0.3f;

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

            if (keysPressed == true && DrivingControler.CanMove == false)
            {
                BoringMeter.slideValue = BoringMeter.slideValue - removeValue;
                keysPressed = false;
                keySlider.value = 0f;
                value = 3f;
            uiButton.interactable = true;

            }
            else
            {
                if (DrivingControler.CanMove == false)
                {
                    StartCoroutine(keyCounter());
                uiButton.interactable = false;
                
                }
                else
                {
                    keySlider.value = 0f;
                uiButton.interactable = true;
                }
            }

        }
    
    
    IEnumerator keyCounter()
    {

        

        yield return new WaitForSeconds(0.3f);
        keySlider.value += 0.3f;

        if (keySlider.value == 1f)
        {
            
            keysPressed = true;
            Keys();
        }
        else
        {
            Keys();

        }
        


    }
}
