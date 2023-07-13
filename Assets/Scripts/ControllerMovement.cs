using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerMovement : MonoBehaviour
{
    public float movementSpeed = 0.8f;
    public Rigidbody2D rb;


    private float xInput;
    private float yInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementControllerPlayer();
        ProcessInputs();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }

    private void movementControllerPlayer()
    {
        if (Gamepad.all.Count > 0)
        {
            rb.AddForce(new Vector3(xInput, 0f, yInput) * movementSpeed);

        }
    }
}