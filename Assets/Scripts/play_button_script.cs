using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Eliot Pearson 
// CMSC 437 - Spirng 2024

public class play_button_script : MonoBehaviour
{

    public int sceneNumber;
    //[SerializeField] private string newGameScene = "Play_Room";

    
    private void PlayButton() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previousScene" + sceneNumber, currentScene);
        SceneManager.LoadScene(11);
        
    }

    public void PlayWithSound() {
        Invoke("PlayButton", 1);
    }

    public void PlayBall() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previousScene" + sceneNumber, currentScene);
        SceneManager.LoadScene(7);
        
    }

    public void BallWithSound() {
        Invoke("PlayBall", 1);
    }

    public void PlayDressUp() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previousScene" + sceneNumber, currentScene);
        SceneManager.LoadScene(10);
        
    }

    public void DressUpWithSound() {
        Invoke("PlayDressUp", 1);
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
