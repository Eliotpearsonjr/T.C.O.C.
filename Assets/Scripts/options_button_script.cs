using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class options_button_script : MonoBehaviour
{
    // Start is called before the first frame update
    public int sceneNumber;
    [SerializeField] private string newGameScene = "Options";
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
