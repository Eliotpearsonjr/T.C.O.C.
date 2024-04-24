using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class receive_food_script : MonoBehaviour, IDropHandler
{
    SpriteRenderer renderer;
    GameObject yum;

    private void Start() {

    }

    private void Update() {
    
    }
    private void BackToStart() {
        SceneManager.LoadScene(0);
    }
    public void OnDrop(PointerEventData eventData) {

        yum = GameObject.Find("Yum");
        renderer = yum.GetComponent<SpriteRenderer>();

        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            
            renderer.enabled = !renderer.enabled;
            Invoke("BackToStart", 2);
            
        }
   }

}
