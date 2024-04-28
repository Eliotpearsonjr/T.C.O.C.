using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// Eliot Pearson 
// CMSC 437 - Spirng 2024

public class receive_food_script : MonoBehaviour, IDropHandler
{
    SpriteRenderer renderer;            // renderer obj for yum message
    GameObject yum;                     // yum message object
    public AudioSource audioSource;     // audio object
    public AudioClip yumSound;          // fairy success sound

    // standard functions
    private void Start() {

    }

    private void Update() {
    
    }
    // goes back to the home screen
    private void BackToStart() {
        SceneManager.LoadScene(0);
    }

    // called when food item is dropped in the item slot
    public void OnDrop(PointerEventData eventData) {

        yum = GameObject.Find("Yum");
        renderer = yum.GetComponent<SpriteRenderer>();

        // allows for a sound to play after displaying the message
        audioSource.clip = yumSound;
        audioSource.Play();

        // display yum message once food is eaten
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            renderer.enabled = !renderer.enabled;
            Invoke("BackToStart", 2);
            
        }
   }

}
