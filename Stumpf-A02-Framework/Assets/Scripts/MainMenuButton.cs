using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MainMenuButton : MonoBehaviour
{
    public Button mainButton;

    // Start is called before the first frame update
    void Start()
    {
        mainButton.onClick.AddListener(Testing);

    }

    // Update is called once per frame
    void Update()
    {
    }

    void Testing()
    {
        Debug.Log("Success!");
    }
}





