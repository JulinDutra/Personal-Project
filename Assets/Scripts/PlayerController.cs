using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private Rigidbody rb;
    private float xMaxBound = 22.77f, xMinBound = -22.8f;
    public bool gameOver = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver)
            MovePLayer();
        ConstraintPlayerPosition();

    }

    // Moves the player based on arrow keys input
    void MovePLayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.right * speed * horizontalInput);
        rb.AddForce(Vector3.up * speed * verticalInput);
    }

    // Prevent the player from leaving the screen
    void ConstraintPlayerPosition()
    {
        if (transform.position.x < xMinBound)
        {
            transform.position = new Vector3(xMinBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xMaxBound)
        {
            transform.position = new Vector3(xMaxBound, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
        }
    }
}
