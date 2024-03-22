using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eat_button_script : MonoBehaviour
{
    Text textfield;
    // Start is called before the first frame update
    void Start()
    {
        textfield = GameObject.Find("Text").GetComponent<Text>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
