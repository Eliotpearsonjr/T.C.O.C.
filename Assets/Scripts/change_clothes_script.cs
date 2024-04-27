using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change_clothes_script : MonoBehaviour
{

    // image fields to be updated
    public Sprite imageForItem0;
    public Sprite imageForItem1;

    public Sprite imageForItem2;
    public Sprite imageForItem3;
    public Sprite imageForItem4;
    public Sprite imageForItem5;

    // game objects to reference
    public GameObject item0;            // no clothes chosen

    public GameObject item1;            // red gingham shirt
    public GameObject item2;            // star shirt
    public GameObject item3;            // blue polo shirt
    public GameObject item4;            // purple with white under shirt
    public GameObject item5;            // sailor uniform shirt

    // Start is called before the first frame update
    void Start()
    {
        item0.AddComponent(typeof(Image));                                  // initial load of sprite
        imageForItem0 = Resources.Load<Sprite>("Sprites/Kitsune_Happy");    // with no clothing chosen

    }

    public void LoadItem1() {
        imageForItem1 = Resources.Load<Sprite>("Sprites/Red_Gingham");
        item1.SetActive(true);              // set true after load

        // disable all other shirts not chosen
        item0.SetActive(false);
        item2.SetActive(false);
        item3.SetActive(false);
        item4.SetActive(false);
        item5.SetActive(false);
        item1.GetComponent<Image>().sprite = imageForItem1;
                
    }

    public void LoadItem2() {
        imageForItem2 = Resources.Load<Sprite>("Sprites/Star_Shirt");
        item2.SetActive(true);              // set true after load

        // disable all other shirts not chosen
        item0.SetActive(false);
        item1.SetActive(false);
        item3.SetActive(false);
        item4.SetActive(false);
        item5.SetActive(false);
        item2.GetComponent<Image>().sprite = imageForItem2;
        
    }

    public void LoadItem3() {
        imageForItem3 = Resources.Load<Sprite>("Sprites/Blue_Polo");
        item3.SetActive(true);              // set true after load

        // disable all other shirts not chosen
        item0.SetActive(false);
        item1.SetActive(false);
        item2.SetActive(false);
        item4.SetActive(false);
        item5.SetActive(false);
        item3.GetComponent<Image>().sprite = imageForItem3;
        
    }

    public void LoadItem4() {
        imageForItem4 = Resources.Load<Sprite>("Sprites/Purple_And_White_Shirt");
        item4.SetActive(true);              // set true after load

        // disable all other shirts not chosen
        item0.SetActive(false);
        item1.SetActive(false);
        item2.SetActive(false);
        item3.SetActive(false);
        item5.SetActive(false);
        item4.GetComponent<Image>().sprite = imageForItem4;
        
    }

    public void LoadItem5() {
        imageForItem5 = Resources.Load<Sprite>("Sprites/Sailor_Shirt");
        item5.SetActive(true);              // set true after load

        // disable all other shirts not chosen
        item0.SetActive(false);
        item1.SetActive(false);
        item2.SetActive(false);
        item3.SetActive(false);
        item4.SetActive(false);
        item5.GetComponent<Image>().sprite = imageForItem5;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
