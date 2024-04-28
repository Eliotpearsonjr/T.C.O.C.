using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Eliot Pearson 
// CMSC 437 - Spirng 2024

public class bath_button_script : MonoBehaviour
{
    public int sceneNumber;

    // invoked to load the bathroom scene
    public void BathButton() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previousScene" + sceneNumber, currentScene);
        SceneManager.LoadScene(4);

    }

    // sound effect plays on button press
    public void BathWithSound() {
        Invoke("BathButton", 1);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
