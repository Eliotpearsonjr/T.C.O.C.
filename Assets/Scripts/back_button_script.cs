using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Eliot Pearson 
// CMSC 437 - Spirng 2024

public class back_button_script : MonoBehaviour
{
    
    int sceneIndex;             // accesses scene 0 for the home screen
    int sceneToOpen;
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(!PlayerPrefs.HasKey("previous scene" + sceneIndex)) {
            PlayerPrefs.SetInt("previous scene" + sceneIndex, sceneIndex);
        }

        sceneToOpen = PlayerPrefs.GetInt("previous scene" + sceneIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // home screen
    public void BackButton() {
        SceneManager.LoadScene(0);
    }
}
