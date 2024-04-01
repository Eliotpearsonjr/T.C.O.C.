using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class food_melon_script : MonoBehaviour
{
    public int sceneNumber;
    [SerializeField] private string newGameScene = "Food_Melon";
    public void EatMelon() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previousScene" + sceneNumber, currentScene);
        SceneManager.LoadScene(3);
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
