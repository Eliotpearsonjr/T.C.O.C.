using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Eliot Pearson 
// CMSC 437 - Spirng 2024

public class button_sound_script : MonoBehaviour
{
   public AudioSource audioSource;
   public AudioClip clickSound;

    // plays the speficied sound on click
   public void ButtonSound() {
    audioSource.clip = clickSound;
    audioSource.Play();

   }
}
