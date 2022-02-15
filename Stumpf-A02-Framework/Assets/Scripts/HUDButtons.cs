using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// https://stackoverflow.com/questions/53160575/should-i-use-a-single-script-on-multiple-buttons-in-unity-or-create-a-script-fo

public class HUDButtons : MonoBehaviour
{
    public Button exitButton;
    public Button playButton;
    public Button buildingButton;
    public Button insuranceButton;
    public Button financeButton;
    public Button otherButton;

    public GameObject insuranceOptions;
    public GameObject buildingOptions;
    public GameObject financeOptions;
    public GameObject otherOptions;

    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(() => buttonCallBack(exitButton));
        playButton.onClick.AddListener(() => buttonCallBack(playButton));
        buildingButton.onClick.AddListener(() => buttonCallBack(buildingButton));
        insuranceButton.onClick.AddListener(() => buttonCallBack(insuranceButton));
        financeButton.onClick.AddListener(() => buttonCallBack(financeButton));
        otherButton.onClick.AddListener(() => buttonCallBack(otherButton));

     }

    void buttonCallBack(Button button)
    {
        if(button == exitButton) {
            SceneManager.LoadScene("MainMenu");
        }
        if(button == playButton) {
            Debug.Log("TODO: Add Play Functionality");
        }
        if(button == insuranceButton) {
            insuranceOptions.SetActive(true);
        }
        if(button == buildingButton) {
            buildingOptions.SetActive(true);
        }
        if(button == financeButton) {
            financeOptions.SetActive(true);
        }
        if(button == otherButton) {
            otherOptions.SetActive(true);
        }
    }
}





