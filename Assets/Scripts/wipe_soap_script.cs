using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Eliot Pearson 
// CMSC 437 - Spirng 2024

public class wipe_soap_script : MonoBehaviour
{
        public BoxCollider2D wipeBoxCollider2D;
        private void Awake() {
        wipeBoxCollider2D = GetComponent<BoxCollider2D>();
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
