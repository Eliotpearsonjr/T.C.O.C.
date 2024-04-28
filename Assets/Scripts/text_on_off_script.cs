using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;                // specifically to access the TMP object text fields
// Eliot Pearson 
// CMSC 437 - Spirng 2024

public class text_on_off_script : MonoBehaviour
{
    public TextMeshProUGUI backButtonOptionsText;               // corresponding text

    public int isEnabled;                                       // toggle for text redundancy

    public void BackButtonTextOn() {
        if (isEnabled == 0) {
            Debug.Log("isEnabled is now 1");
            isEnabled = 1;
            backButtonOptionsText.text = "Back";
            
        } else if (isEnabled == 1) {
            Debug.Log("isEnabled is now 0");
            isEnabled = 0;
            backButtonOptionsText.text = " ";

        }
        
    }

    // Start is called before the first frame update
    // initially have back button display no text
    void Start()
    {
        backButtonOptionsText.text = " ";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
