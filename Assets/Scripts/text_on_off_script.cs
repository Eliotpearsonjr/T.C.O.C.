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
    public TextMeshProUGUI backButtonOptionsText;                 // corresponding text

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
            
        } else if (isEnabled == 1) {
            Debug.Log("isEnabled is now 0");
            isEnabled = 0;
            backButtonOptionsText.text = " ";
        
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        backButtonOptionsText.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
