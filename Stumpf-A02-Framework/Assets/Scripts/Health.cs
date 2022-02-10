using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// https://www.youtube.com/watch?v=BS5fam0--H8

public class Health : MonoBehaviour
{

    public float maxHealth = 100;
    public float currentHealth;
    public Image healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    // Update is called once per frame
    void Update()
    {
        // Just testing
        if(Input.GetKeyDown(KeyCode.Space)) {
            currentHealth -= 10;
            UpdateHealthBar();
        }
    }


    public void UpdateHealthBar() {
        healthBar.fillAmount = currentHealth/maxHealth;
        Debug.Log(currentHealth);
        Debug.Log(maxHealth);
        Debug.Log(currentHealth/maxHealth);
    }
}
