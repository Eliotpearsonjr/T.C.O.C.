using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TouchPhase = UnityEngine.TouchPhase;  // specifices TouchPhase as it is ambiguous
                                            // between UnityEngine and InputSystem
// Eliot Pearson 
// CMSC 437 - Spirng 2024

public class tap_jump_script : MonoBehaviour
{
    private Rigidbody2D rigid;

    private float jumpForce = 450f;                     // sends ball upwards
    [SerializeField] private float velocity = 1.5f;     // calculation for ball to gain height on tap
    [SerializeField] private float rotationSpeed = 10f; // turns ball upon falling or collision

    
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();             // hitbox of the ball

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            rigid.AddForce(new Vector2(0.05f, jumpForce), ForceMode2D.Force);

        }
    }

    // rotation of the ball
    private void FixedUpdate() {
        transform.rotation = Quaternion.Euler(0,0, rigid.velocity.y * rotationSpeed);
    }
}
