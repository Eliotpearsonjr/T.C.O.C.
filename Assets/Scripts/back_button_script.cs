using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_button_script : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] private string newGameScene = "Game";
    
    int sceneIndex;
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

    public void BackButton() {
        SceneManager.LoadScene(0);
    }
}
