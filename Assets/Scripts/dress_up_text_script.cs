using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;                    // specifically to access the TMP object text fields
// Eliot Pearson 
// CMSC 437 - Spirng 2024

public class dress_up_text_script : MonoBehaviour
{
    public TextMeshProUGUI item1text;                           // text of item 1
    public TextMeshProUGUI item2text;                           // text of item 2
    public TextMeshProUGUI item3text;                           // text of item 3
    public TextMeshProUGUI item4text;                           // text of item 4
    public TextMeshProUGUI item5text;                           // text of item 5

    public int isEnabled;                                       // the toggle for text redundancy

    public void DressUpTextOn() {
        if (isEnabled == 0) {
            Debug.Log("isEnabled is now 1");
            isEnabled = 1;
            
            item1text.text = "Red Gingham";
            item2text.text = "Star Shirt";
            item3text.text = "Blue Polo";
            item4text.text = "Purple Casual";
            item5text.text = "Sailor Uniform";
            
        } else if (isEnabled == 1) {
            Debug.Log("isEnabled is now 0");
            isEnabled = 0;
            
            item1text.text = " ";
            item2text.text = " ";
            item3text.text = " ";
            item4text.text = " ";
            item5text.text = " ";
        
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
        item1text.text = " ";
        item2text.text = " ";
        item3text.text = " ";
        item4text.text = " ";
        item5text.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
