using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public GameObject tutorial1;
    public GameObject tutorial2;
    public GameObject tutorial3;
    public GameObject tutorial4;

    public float tutorialStage;
    public bool tutCheck;

    public Text buttonText;
    public Text tutText;

    public void Start()
    {
        tutorialStage = 0f;
        tutorial2.SetActive(false);
        tutorial3.SetActive(false);
        tutorial4.SetActive(false);
        buttonText.text = "Please Wait";


    }

    public void Update()
    {
        StartCoroutine(tutorialSat());
    }

    private IEnumerator tutorialSat()
    {
        if (tutorialStage == 0f)
        {
            yield return new WaitForSeconds(2f);
            tutText.text = "Move R or L using A & D";
            tutorial1.SetActive(false);
            tutorial2.SetActive(true);

            yield return new WaitForSeconds(2f);
            tutorialStage = 1;


        }

        if (tutorialStage == 1f)
        {
            tutText.text = "Press E to Open Boredom Window || Be careful not crash while in the Menu";
            tutorial2.SetActive(false);
            tutorial3.SetActive(true);
            yield return new WaitForSeconds(2f);
            tutorialStage = 2f;

        }

        if (tutorialStage == 2)
        {
            tutText.text = "Collect Money in order to unlock the differnet items";
            tutorial3.SetActive(false);
            tutorial4.SetActive(true);
            yield return new WaitForSeconds(2f);
            tutorialStage = 3f;

            buttonText.text = "Done";

        }

        if (tutorialStage == 3f)
        {
            yield return new WaitForSeconds(2f);
            tutorialStage = 0f;
            SceneManager.LoadScene("TesterScene");

        }
    }

}


