using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BorringManager : MonoBehaviour
{
    public float keysRemoveValue = 0.3f;
    public float toysRemoveValue = 0.5f;
    public float tabletRemoveValue = 0.73f;

    private float value = 3f;

    //state of the menu closed/open
    public static bool boringMenu;
    public static bool keysPressed;
    public static bool toysPressed;
    public static bool tabletPressed;

    public bool toys = false;
    public bool tablet = false;


    public GameObject boringMenuUI;

    public Button keyButton;
    public Button toysButton;
    public Button tabletButton;

    public Animation forward;
    public Animation backward;

    public Slider keySlider;
    public Slider toySlider;
    public Slider tabletSlider;



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
        if (Money.moneyAmount >= 5f && toys == false )
        {
            toysButton.interactable = true;
        }
        else
        {
            toysButton.interactable = false;
        }

        if (Money.moneyAmount >= 9f && tablet == false)
        {
            tabletButton.interactable = true;
        }
        else
        {
            tabletButton.interactable = false;
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
            BoringMeter.slideValue = BoringMeter.slideValue - keysRemoveValue;
            keysPressed = false;
            keySlider.value = 0f;
            value = 3f;
            keyButton.interactable = true;

        }
        else
        {
            if (DrivingControler.CanMove == false)
            {
                StartCoroutine(keyCounter());
                keyButton.interactable = false;

            }
            else
            {
                keySlider.value = 0f;
                keyButton.interactable = true;

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

    public void Toys()
    {

        if (toysPressed == true && DrivingControler.CanMove == false)
        {
            BoringMeter.slideValue = BoringMeter.slideValue - toysRemoveValue;
            toysPressed = false;
            toySlider.value = 0f;
            value = 3f;
            toysButton.interactable = true;

        }
        else
        {
            if (DrivingControler.CanMove == false)
            {
                StartCoroutine(toysCounter());
                toysButton.interactable = false;
                toys = true;

            }
            else
            {
                toySlider.value = 0f;
                toysButton.interactable = true;
                toys = false;
            }
        }
    }


        IEnumerator toysCounter()
        {



            yield return new WaitForSeconds(0.3f);
            toySlider.value += 0.2f;

            if (toySlider.value == 1f)
            {

                toysPressed = true;
                toys = false;
                Toys();
            }
            else
            {
                Toys();

            }



        }

    public void Tablet()
    {

        if (tabletPressed == true && DrivingControler.CanMove == false)
        {
            BoringMeter.slideValue = BoringMeter.slideValue - tabletRemoveValue;
            tabletPressed = false;
            tabletSlider.value = 0f;
            value = 3f;
            tabletButton.interactable = true;

        }
        else
        {
            if (DrivingControler.CanMove == false)
            {
                StartCoroutine(tabletCounter());
                tabletButton.interactable = false;
                tablet = true;

            }
            else
            {
                toySlider.value = 0f;
                toysButton.interactable = true;
                tablet = false;
            }
        }
    }


    IEnumerator tabletCounter()
    {



        yield return new WaitForSeconds(0.3f);
        tabletSlider.value += 0.14f;

        if (tabletSlider.value == 1f)
        {

            tabletPressed = true;
            tablet = false;
            Tablet();
        }
        else
        {
            Tablet();

        }



    }



}
