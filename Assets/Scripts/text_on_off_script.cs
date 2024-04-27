using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class text_on_off_script : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI backButtonSerialize;
    //GameObject backButton;
    //public Button backButtonOptions;            // the back button in the options menu
    public TextMeshProUGUI backButtonOptionsText;               // corresponding text

    public int isEnabled;

    void Awake() {
        //backButtonOptionsText.text = " ";
        //backButton = GameObject.Find("Back_Button");
        //backButtonOptions = backButton.GetComponent<Button>();
        //backButtonOptionsText = backButtonOptions.GetComponent<TMP_Text>();
        //backButtonOptionsText.text = "Back";

    }

    public void BackButtonTextOn() {
        if (isEnabled == 0) {
            Debug.Log("isEnabled is now 1");
            isEnabled = 1;
            backButtonOptionsText.text = "Back";
            // item1text.text = "Red Gingham";
            // item2text.text = "Star Shirt";
            // item3text.text = "Blue Polo";
            // item4text.text = "Purple and White";
            // item5text.text = "Sailor Uniform";
            
        } else if (isEnabled == 1) {
            Debug.Log("isEnabled is now 0");
            isEnabled = 0;
            backButtonOptionsText.text = " ";
            // item1text.text = " ";
            // item2text.text = " ";
            // item3text.text = " ";
            // item4text.text = " ";
            // item5text.text = " ";
        
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        backButtonOptionsText.text = " ";
        // item1text.text = " ";
        // item2text.text = " ";
        // item3text.text = " ";
        // item4text.text = " ";
        // item5text.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
