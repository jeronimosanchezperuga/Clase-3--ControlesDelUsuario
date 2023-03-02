using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDelCuadradito : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,speed,0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0,0,rotationSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotationSpeed);
        }
    }
}
