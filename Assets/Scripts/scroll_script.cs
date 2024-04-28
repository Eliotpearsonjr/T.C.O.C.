using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// Eliot Pearson 
// CMSC 437 - Spirng 2024
public class scroll_script : MonoBehaviour
{
    [SerializeField] private RawImage image;
    [SerializeField] private float x, y;


    // Update is called once per frame
    void Update()
    {
        image.uvRect = new Rect(image.uvRect.position + new Vector2(x, y) * Time.deltaTime * 5, image.uvRect.size);
    }
}
