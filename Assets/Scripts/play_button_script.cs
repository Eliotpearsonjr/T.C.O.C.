using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play_button_script : MonoBehaviour
{

    public int sceneNumber;
    [SerializeField] private string newGameScene = "Play_Room";
    public void PlayButton() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previousScene" + sceneNumber, currentScene);
        SceneManager.LoadScene(7);
        //SceneManager.LoadScene(newGameScene);
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
