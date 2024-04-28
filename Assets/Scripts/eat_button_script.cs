using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Eliot Pearson 
// CMSC 437 - Spirng 2024

public class eat_button_script : MonoBehaviour
{
    public int sceneNumber;
    public void EatButton() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previousScene" + sceneNumber, currentScene);
        SceneManager.LoadScene(2);
        
    }

    public void EatWithSound() {
        Invoke("EatButton", 1);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
