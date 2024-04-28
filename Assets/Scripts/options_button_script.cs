using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Eliot Pearson 
// CMSC 437 - Spirng 2024

public class options_button_script : MonoBehaviour
{
    public int sceneNumber;

    // loads the options menu
    public void OptionsButton() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previousScene" + sceneNumber, currentScene);
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene(newGameScene);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
