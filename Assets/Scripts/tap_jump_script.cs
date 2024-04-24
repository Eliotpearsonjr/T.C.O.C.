using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TouchPhase = UnityEngine.TouchPhase;  // specifices TouchPhase as it is ambiguous
                                            // between UnityEngine and InputSystem

public class tap_jump_script : MonoBehaviour
{
    private Rigidbody2D rigid;

    private float jumpForce = 450f;
    [SerializeField] private float velocity = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;

    
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            rigid.AddForce(new Vector2(0.05f, jumpForce), ForceMode2D.Force);
            //rigid.velocity = Vector2.up * velocity;
        }

        // if(Touchscreen.current.touches > 0) {
        //     rigid.velocity = Vector2.up * velocity;
        // }
    }

    private void FixedUpdate() {
        transform.rotation = Quaternion.Euler(0,0, rigid.velocity.y * rotationSpeed);
    }
}
