using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class drag_soap_script : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    
    public RectTransform rectTransform;
    public BoxCollider2D soapBoxCollider2D;
    public BoxCollider2D wipeArea;      // the area where the soap will be wiped
    public wipe_soap_script wipeObj;    // references wipe_soap_script object
    private CanvasGroup canvasGroup;

    public int sceneNumber;
    [SerializeField] private string newGameScene = "All_Clean";

    // timer variables
    private const float TICK_TIMER_MAX = 4f;  // number of seconds to wipe pet
    private int tick;
    private float tickTimer;

    private void BackToStart() {
        SceneManager.LoadScene(0);
    }

    public void AllClean() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previousScene" + sceneNumber, currentScene);
        SceneManager.LoadScene(9);
        
    }

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        wipeObj = FindObjectOfType<wipe_soap_script>();
        soapBoxCollider2D = GetComponent<BoxCollider2D>();
        wipeArea = wipeObj.GetComponent<BoxCollider2D>();

        // timer 
        tick = 0;

    }
     public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .9f;
        canvasGroup.blocksRaycasts = false;
    }
     public void OnDrag(PointerEventData eventData) {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta;
        Collider2D[] overlap = Physics2D.OverlapAreaAll(wipeArea.bounds.min, wipeArea.bounds.max);
        
        if(overlap.Length >= 1) {
            Debug.Log("Overlap successful!");
        }

        
    }
     public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        //canvasGroup.interactable = false;
        if(tickTimer >= TICK_TIMER_MAX) {
            Invoke("AllClean", 1);
        }
    }
    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("OnPointerDown");
    }

    public void Update() {
        tickTimer += Time.deltaTime;
        
    }
}
