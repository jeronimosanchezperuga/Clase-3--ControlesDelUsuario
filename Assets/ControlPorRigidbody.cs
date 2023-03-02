using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPorRigidbody : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector3 velocityValue;
    public Vector2 jumpForce;
    public Vector2 movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.velocity = velocityValue;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(jumpForce,ForceMode2D.Impulse);
        }
       
        rb.AddForce(movementSpeed * Input.GetAxisRaw("Horizontal"), ForceMode2D.Impulse);

        Debug.Log(Input.GetAxis("Horizontal"));
    }
}
