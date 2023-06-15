using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class controllerMovement : MonoBehaviour
{
    public float movementSpeed = 0.6f;
    public Rigidbody rb;

    private float xInput;
    private float yInput;

    // Start is called as you start the game, we use it to initially give values to things
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        movementController();
        ProcessInputs();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }

    private void movementController()
    {
        if (Gamepad.all.Count > 0)
        {
            rb.AddForce(new Vector3(xInput, 0f, yInput) * movementSpeed);


            if (Gamepad.all[0].aButton.isPressed)
            {

            }

            if (Gamepad.all[0].startButton.isPressed)
            {
                Debug.Log("PAUSE MENU");
            }
        }
    }
}
