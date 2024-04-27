using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eat_button_script : MonoBehaviour
{
    // Start is called before the first frame update
    public int sceneNumber;
    [SerializeField] private string newGameScene = "Fridge";
    public void EatButton() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previousScene" + sceneNumber, currentScene);
        SceneManager.LoadScene(2);
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
